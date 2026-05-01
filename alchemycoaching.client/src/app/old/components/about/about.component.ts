import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-about',
  imports: [RouterLink],
  templateUrl: './about.component.html',
  styleUrl: './about.component.scss'
})
export class AboutComponent {
  title = 'Get unstuck.';
  description = 'Life gets tough and messy. Everyone struggles from time to time. And often a little bit of support - a listening ear, connection, accountability - are all that are necessary to make profound changes in your life, wellbeing, and happiness. That’s where Alchemy comes in! Together, we’ll face these challenges and create something new.  That’s the magic of transformation.  Get unstuck.';
}
