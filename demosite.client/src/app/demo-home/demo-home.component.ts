import { Component, inject } from '@angular/core';
import { DemoAccountService } from '../services/demo-account-service';
import { DemoNavBarComponent } from '../demo-nav-bar/demo-nav-bar.component';

@Component({
  selector: 'app-demo-home',
  imports: [DemoNavBarComponent],
  templateUrl: './demo-home.component.html',
  styleUrl: './demo-home.component.css'
})
export class DemoHomeComponent {
  accountService = inject(DemoAccountService);
}

