import { createReducer, on } from '@ngrx/store';
import { LoginActions } from '../actions/auth.actions';
import { initialAuthState } from '../state/auth.state';

export const authFeatureKey = 'auth';

export const authReducer = createReducer(
  initialAuthState,
  on(LoginActions.submit, (state) => ({
    ...state,
    loading: true,
    error: null
  })),
  on(LoginActions.success, (state, { user }) => ({
    ...state,
    user,
    loading: false,
    error: null
  })),
  on(LoginActions.failure, (state, { error }) => ({
    ...state,
    loading: false,
    error
  })),
  on(LoginActions.logout, () => ({ ...initialAuthState }))
);
