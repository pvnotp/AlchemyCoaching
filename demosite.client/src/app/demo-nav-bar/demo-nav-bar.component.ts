import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DemoAccountService } from '../services/demo-account-service';
import { RouterLink } from '@angular/router';
import { LoginComponent } from '../login/login.component';

@Component({
  selector: 'app-demo-nav-bar',
  standalone: true,
  imports: [FormsModule, RouterLink, LoginComponent],
  templateUrl: './demo-nav-bar.component.html',
  styleUrl: './demo-nav-bar.component.scss'
})
export class DemoNavBarComponent {

  accountService = inject(DemoAccountService);
  displayLogin: boolean = false;
  constructor() {
    console.log("hello" + this.accountService.currentUser());
  }
  

  toggleLogin() {
    this.displayLogin = !this.displayLogin;
  }

  logout() {
    this.accountService.logout();
  }
}
