import { Component, OnInit, inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DatePickerComponent } from '../date-picker/date-picker.component';
import { TimePickerComponent } from '../time-picker/time-picker.component';

@Component({
  selector: 'app-schedule',
  standalone: true,
  imports: [DatePickerComponent, TimePickerComponent],
  templateUrl: './schedule.component.html',
  styleUrl: './schedule.component.scss'
})
export class ScheduleComponent implements OnInit {
  private readonly route = inject(ActivatedRoute);

  type = '';
  duration = '';
  selectedDate = (() => { const d = new Date(); d.setHours(0, 0, 0, 0); return d; })();

  onDateSelected(date: Date): void {
    this.selectedDate = date;
  }

  get titleText(): string {
    const normalizedType = this.type.trim().toLowerCase();

    if (normalizedType === 'vibe check') {
      return 'Schedule a vibe check';
    }

    return 'Schedule a session';
  }

  get contentText(): string {
    const normalizedType = this.type.trim().toLowerCase();

    if (normalizedType === 'vibe check') {
      return "Let's have a brief call to talk about what you're looking to achieve and whether or not I'm the right person to guide you.";
    }

    return 'Choose a session type to see the scheduling details.';
  }

  ngOnInit(): void {
    this.route.queryParamMap.subscribe((params) => {
      this.type = params.get('type') ?? '';
      this.duration = params.get('duration') ?? '';
    });
  }
}
