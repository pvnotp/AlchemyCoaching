import { createFeatureSelector, createSelector } from '@ngrx/store';
import { authFeatureKey } from '../reducers/auth.reducer';
import { AuthState } from '../state/auth.state';

export const selectAuthState = createFeatureSelector<AuthState>(authFeatureKey);

export const selectUser = createSelector(
  selectAuthState,
  (state) => state.user
);

export const selectLoginLoading = createSelector(
  selectAuthState,
  (state) => state.loading
);

export const selectLoginError = createSelector(
  selectAuthState,
  (state) => state.error
);

export const selectLoginErrorMessage = createSelector(
  selectLoginError,
  (error) => {
    if (!error) {
      return null;
    }

    const status = (error as { status?: number }).status;

    return status === 401
      ? 'Incorrect username or password'
      : 'Something went wrong!  Please refresh your page and try again.';
  }
);
