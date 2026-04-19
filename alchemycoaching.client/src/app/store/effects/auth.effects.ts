import { inject, Injectable } from '@angular/core';
import { Store } from '@ngrx/store';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { LoginActions, RoleActions } from '../actions/auth.actions';
import { AuthService } from '../../services/auth-service';
import { catchError, map, of, switchMap, withLatestFrom } from 'rxjs';
import { selectUser } from '../selectors/auth.selectors';

@Injectable()
export class AuthEffects {
  private actions$ = inject(Actions);
  private authService = inject(AuthService);
  private store = inject(Store);

  submitLogin$ = createEffect(() =>
    this.actions$.pipe(
      ofType(LoginActions.submit),
      switchMap(({ credentials }) =>
        this.authService.login(credentials).pipe(
          map((user) => LoginActions.success({ user })),
          catchError((error) => of(LoginActions.failure({ error })))
        )
      )
    )
  );

  fetchRoleOnLoginSuccess$ = createEffect(() =>
    this.actions$.pipe(
      ofType(LoginActions.success),
      map(() => RoleActions.fetch())
    )
  );

  fetchRole$ = createEffect(() =>
    this.actions$.pipe(
      ofType(RoleActions.fetch),
      withLatestFrom(this.store.select(selectUser)),
      switchMap(([, user]) => {
        const userId = user?.id;

        if (!userId) {
          return of(RoleActions.failure({ error: new Error('User id is missing.') }));
        }

        return this.authService.getUserRole(userId).pipe(
          map((role: string) => RoleActions.success({ role })),
          catchError((error) => of(RoleActions.failure({ error })))
        );
      })
    )
  );

  logout$ = createEffect(
    () =>
      this.actions$.pipe(
        ofType(LoginActions.logout),
        map(() => this.authService.logout())
      ),
    { dispatch: false }
  );
}
