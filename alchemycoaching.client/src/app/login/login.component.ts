import { Component, HostListener, inject, input, output, OutputEmitterRef } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService, userLogin } from '../services/account-service';
import { Router } from '@angular/router';
import { finalize, mergeMap } from 'rxjs/operators';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {

  accountService = inject(AccountService);
  router = inject(Router);
  loginSuccessful: OutputEmitterRef<void> = output();
  loading = false;
  errorMessage = "";
  userLogin: userLogin = {
    email: null,
    password: null
  }

  login() {
    this.errorMessage = "";
    this.loading = true;
    document.getElementById("submit-btn")?.setAttribute("disabled", "true");
    this.accountService.setToken(this.userLogin).pipe(
      mergeMap(_ => this.accountService.setUser(this.userLogin)),
      finalize(() => {
        document.getElementById("submit-btn")?.removeAttribute("disabled");
        this.loading = false;
        console.log('yo');
      })
    ).subscribe({
      next: _ => this.loginSuccessful.emit(),
      error: error => {
        if (error.status == 401) {
          this.errorMessage = "Incorrect username or password";
        }
        else if (error.status == 500) {
          this.errorMessage = "Something went wrong!";
        } 
      }
    });
  }
  
}
