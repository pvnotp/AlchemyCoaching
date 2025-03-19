
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { DemoNavBarComponent } from './demo-nav-bar/demo-nav-bar.component';
import { DemoAccountService } from './services/demo-account-service';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  imports: [DemoNavBarComponent, RouterOutlet],
  standalone: true,
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'Client Portal';
  accountService = inject(DemoAccountService);

  ngOnInit(): void {
    this.setCurrentUser();
  }

  setCurrentUser() {
    const userString = localStorage.getItem('user');
    if (!userString) return;
    const user = JSON.parse(userString);
    this.accountService.currentUser.set(user);
  }
}
