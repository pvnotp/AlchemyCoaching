
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Store } from '@ngrx/store';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  imports: [RouterOutlet],
  standalone: true,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Highly Zensitive SalamanDr';
  private store = inject(Store);
}
