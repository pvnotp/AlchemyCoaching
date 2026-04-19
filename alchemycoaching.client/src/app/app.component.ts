
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { User } from './services/auth-service';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { Store } from '@ngrx/store';
import { LoginActions } from './store/actions/auth.actions';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  imports: [NavBarComponent, RouterOutlet],
  standalone: true,
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'Client Portal';
  private store = inject(Store);

  ngOnInit(): void {
    this.setCurrentUser();
  }

  setCurrentUser() {
    const userString = localStorage.getItem('user');
    if (!userString) return;
    const user = JSON.parse(userString) as User;
    this.store.dispatch(LoginActions.success({ user }));
  }
}
