import { Component, HostListener, inject, input, output, OutputEmitterRef } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService, userLogin } from '../services/account-service';
import { Router } from '@angular/router';
import { mergeMap } from 'rxjs/operators';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {

  accountService = inject(AccountService);
  private router = inject(Router);
  loginSuccessful: OutputEmitterRef<void> = output();
  userLogin: userLogin = {
    email: null,
    password: null
  }

  login() {
    this.accountService.setToken(this.userLogin).pipe(
      mergeMap(_ => this.accountService.setUser(this.userLogin))
    ).subscribe({
      next: _ => {
        this.loginSuccessful.emit();
      },
      error: error => console.log(error)
    });
  }
  
}
