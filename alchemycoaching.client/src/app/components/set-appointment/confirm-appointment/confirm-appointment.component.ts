import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CalendarService } from '../../../services/calendar.service';
import { TimeSlot } from '../time-picker/time-picker.component';

interface ConfirmAppointmentFormValue {
  name: string;
  phone: string;
  note: string;
}

@Component({
  selector: 'app-confirm-appointment',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './confirm-appointment.component.html',
  styleUrl: './confirm-appointment.component.scss'
})
export class ConfirmAppointmentComponent implements OnChanges {
  private readonly calendarService = inject(CalendarService);

  @Input() isOpen = false;
  @Input() selectedDate: Date | null = null;
  @Input() selectedSlot: TimeSlot | null = null;

  @Output() closeRequested = new EventEmitter<void>();
  @Output() appointmentCreated = new EventEmitter<void>();

  formValue: ConfirmAppointmentFormValue = { name: '', phone: '', note: '' };
  submitError = '';
  isSubmitting = false;

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['isOpen'] && this.isOpen) {
      this.submitError = '';
    }
  }

  requestClose(): void {
    if (this.isSubmitting) {
      return;
    }

    this.resetForm();
    this.submitError = '';
    this.closeRequested.emit();
  }

  submitAppointment(): void {
    if (!this.selectedDate || !this.selectedSlot || this.isSubmitDisabled) {
      return;
    }

    const start = new Date(this.selectedDate);
    start.setHours(this.selectedSlot.hour, this.selectedSlot.minute, 0, 0);

    const end = new Date(start);
    end.setMinutes(end.getMinutes() + 15);

    const phone = this.formValue.phone.trim();
    const note = this.formValue.note.trim();

    this.isSubmitting = true;
    this.submitError = '';

    this.calendarService.createEvent({
      summary: `Vibe Check with ${this.formValue.name.trim()}`,
      start: start.toISOString(),
      end: end.toISOString(),
      description: note ? `Phone: ${phone}\nNote: ${note}` : `Phone: ${phone}`
    }).subscribe({
      next: () => {
        this.isSubmitting = false;
        this.submitError = '';
        this.resetForm();
        this.appointmentCreated.emit();
      },
      error: () => {
        this.isSubmitting = false;
        this.submitError = 'Could not confirm the appointment. Please try again.';
      }
    });
  }

  get isSubmitDisabled(): boolean {
    return !this.formValue.name.trim() || !this.formValue.phone.trim() || this.isSubmitting;
  }

  get selectedDateText(): string {
    if (!this.selectedDate || !this.selectedSlot) {
      return '';
    }

    const formatter = new Intl.DateTimeFormat('en-US', {
      weekday: 'long',
      month: 'long',
      day: 'numeric'
    });

    return `${formatter.format(this.selectedDate)} at ${this.selectedSlot.label}`;
  }

  private resetForm(): void {
    this.formValue = { name: '', phone: '', note: '' };
  }
}