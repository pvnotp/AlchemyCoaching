import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { UserLogin } from '../../services/auth-service';
import { Store } from '@ngrx/store';
import { LoginActions } from '../../store/actions/auth.actions';
import { selectLoginErrorMessage, selectLoginLoading, selectUser } from '../../store/selectors/auth.selectors';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {

  private store = inject(Store);
  user = this.store.selectSignal(selectUser);
  loading = this.store.selectSignal(selectLoginLoading);
  errorMessage = this.store.selectSignal(selectLoginErrorMessage);
  registerEnabled = false;
  userLogin: UserLogin = {
    email: "",
    password: ""
  }
  name = "";

  login() {
    this.store.dispatch(LoginActions.submit({
      credentials: { ...this.userLogin }
    }));
  }
}
