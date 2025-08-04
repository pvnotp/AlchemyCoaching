import { Component, HostListener, inject, input, output, OutputEmitterRef } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService, userLogin } from '../_services/account-service';
import { Router } from '@angular/router';
import { concatMap, finalize, mergeMap } from 'rxjs/operators';
import { concat } from 'rxjs';


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
  registerEnabled = false;
  userLogin: userLogin = {
    email: "",
    password: ""
  }
  name = "";

  login() {
    this.errorMessage = "";
    this.loading = true;

    this.accountService.login(this.userLogin).pipe(
      finalize(() => {
        this.loading = false;
      })
    ).subscribe({
      next: _ => this.loginSuccessful.emit(),
      error: error => {
        if (error.status == 401) {
          this.errorMessage = "Incorrect username or password";
        }
        else {
          this.errorMessage = "Something went wrong!  Please refresh your page and try again.";
        }
      }
    });
  }
}
