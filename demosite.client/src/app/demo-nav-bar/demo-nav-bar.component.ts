import { Component, inject } from '@angular/core';
import { DemoLoginComponent } from '../demo-login/demo-login.component';
import { FormsModule } from '@angular/forms';
import { DemoAccountService } from '../services/demo-account-service';

@Component({
  selector: 'app-demo-nav-bar',
  standalone: true,
  imports: [FormsModule, DemoLoginComponent],
  templateUrl: './demo-nav-bar.component.html',
  styleUrl: './demo-nav-bar.component.scss'
})
export class DemoNavBarComponent {

  accountService = inject(DemoAccountService);

  logout() {
    this.accountService.logout();
  }
}
