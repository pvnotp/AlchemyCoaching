import { createReducer, on } from '@ngrx/store';
import { LoginActions, RoleActions } from '../actions/auth.actions';
import { initialAuthState } from '../state/auth.state';

export const authFeatureKey = 'auth';

export const authReducer = createReducer(
  initialAuthState,
  on(LoginActions.submit, (state) => ({
    ...state,
    role: null,
    loading: true,
    error: null
  })),
  on(LoginActions.success, (state, { user }) => ({
    ...state,
    user,
    role: null,
    loading: false,
    error: null
  })),
  on(LoginActions.failure, (state, { error }) => ({
    ...state,
    role: null,
    loading: false,
    error
  })),
  on(RoleActions.success, (state, { role }) => ({
    ...state,
    role
  })),
  on(RoleActions.failure, (state) => ({
    ...state,
    role: null
  })),
  on(LoginActions.logout, () => ({ ...initialAuthState }))
);
