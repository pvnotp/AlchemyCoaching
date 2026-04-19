import { createActionGroup, emptyProps, props } from '@ngrx/store';
import { User, UserLogin } from '../../services/account-service';

export const LoginActions = createActionGroup({
  source: 'Login',
  events: {
    Submit: props<{ credentials: UserLogin }>(),
    Success: props<{ user: User }>(),
    Failure: props<{ error: unknown }>(),
    Logout: emptyProps()
  }
});
