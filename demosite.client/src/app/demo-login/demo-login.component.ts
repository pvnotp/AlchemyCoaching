import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DemoAccountService, userLogin } from '../services/demo-account-service';
import { Router } from '@angular/router';
import { mergeMap } from 'rxjs/operators';


@Component({
  selector: 'app-demo-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './demo-login.component.html',
  styleUrl: './demo-login.component.css'
})
export class DemoLoginComponent {

  accountService = inject(DemoAccountService);
  private router = inject(Router);
  userLogin: userLogin = {
    email: null,
    password: null
  };

  login() {
    this.accountService.setToken(this.userLogin).pipe(
      mergeMap(_ => this.accountService.setUser(this.userLogin))
    ).subscribe({
      next: _ => {
        //this.router.navigateByUrl('/members')
      },
      error: error => console.log(error)
    });
  }

}
