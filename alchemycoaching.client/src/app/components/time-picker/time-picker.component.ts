import { Component, Input, OnChanges, SimpleChanges, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CalendarService, CalendarEvent } from '../../services/calendar.service';

export interface TimeSlot {
  hour: number;
  minute: number;
  label: string;
  isHourMark: boolean;
  isBooked: boolean;
}

@Component({
  selector: 'app-time-picker',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './time-picker.component.html',
  styleUrl: './time-picker.component.scss'
})
export class TimePickerComponent implements OnChanges {
  @Input() selectedDate: Date | null = null;

  private readonly calendarService = inject(CalendarService);

  readonly START_HOUR = 11;
  readonly END_HOUR = 21;

  slots: TimeSlot[] = [];
  isLoading = false;
  hasError = false;
  selectedSlotKey: string | null = null;

  onSlotSelected(slot: TimeSlot): void {
    if (slot.isBooked) {
      return;
    }

    this.selectedSlotKey = this.getSlotKey(slot);
  }

  isSelected(slot: TimeSlot): boolean {
    return this.selectedSlotKey === this.getSlotKey(slot);
  }

  confirmSelection(event: Event): void {
    event.stopPropagation();
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['selectedDate'] && this.selectedDate) {
      this.loadEvents(this.selectedDate);
    }
  }

  private loadEvents(date: Date): void {
    this.isLoading = true;
    this.hasError = false;
    this.selectedSlotKey = null;

    this.calendarService.getEventsForDay(date).subscribe({
      next: (events) => {
        this.slots = this.buildSlots(date, events);
        this.isLoading = false;
      },
      error: () => {
        this.hasError = true;
        this.isLoading = false;
      }
    });
  }

  private buildSlots(date: Date, events: CalendarEvent[]): TimeSlot[] {
    const slots: TimeSlot[] = [];

    for (let hour = this.START_HOUR; hour < this.END_HOUR; hour++) {
      for (let minute = 0; minute < 60; minute += 15) {
        const slotStart = new Date(date);
        slotStart.setHours(hour, minute, 0, 0);

        const slotEnd = new Date(slotStart);
        slotEnd.setMinutes(slotEnd.getMinutes() + 15);

        const isBooked = events.some((e) => {
          if (e.isAllDay) return false;
          const eventStart = new Date(e.start);
          const eventEnd = new Date(e.end);
          return eventStart < slotEnd && eventEnd > slotStart;
        });

        const displayHour = hour % 12 === 0 ? 12 : hour % 12;
        const amPm = hour < 12 ? 'AM' : 'PM';
        const label =
          minute === 0
            ? `${displayHour}:00 ${amPm}`
            : `${displayHour}:${minute.toString().padStart(2, '0')}`;

        slots.push({ hour, minute, label, isHourMark: minute === 0, isBooked });
      }
    }

    return slots;
  }

  private getSlotKey(slot: TimeSlot): string {
    return `${slot.hour}-${slot.minute}`;
  }
}
