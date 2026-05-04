import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface CalendarEvent {
  id: string;
  summary: string;
  start: string;
  end: string;
  isAllDay: boolean;
  status: string;
}

@Injectable({ providedIn: 'root' })
export class CalendarService {
  private readonly http = inject(HttpClient);

  getEventsForDay(date: Date): Observable<CalendarEvent[]> {
    const from = new Date(date);
    from.setHours(0, 0, 0, 0);

    const to = new Date(date);
    to.setHours(23, 59, 59, 999);

    return this.http.get<CalendarEvent[]>('/calendar/events', {
      params: {
        from: from.toISOString(),
        to: to.toISOString()
      }
    });
  }
}
