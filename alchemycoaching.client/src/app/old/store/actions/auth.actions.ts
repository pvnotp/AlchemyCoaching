import { createActionGroup, emptyProps, props } from '@ngrx/store';
import { User, UserLogin } from '../../services/auth-service';

export const LoginActions = createActionGroup({
  source: 'Login',
  events: {
    Submit: props<{ credentials: UserLogin }>(),
    Success: props<{ user: User }>(),
    Failure: props<{ error: unknown }>(),
    Logout: emptyProps()
  }
});

export const RoleActions = createActionGroup({
  source: 'Role',
  events: {
    Fetch: emptyProps(),
    Success: props<{ role: string }>(),
    Failure: props<{ error: unknown }>()
  }
});
