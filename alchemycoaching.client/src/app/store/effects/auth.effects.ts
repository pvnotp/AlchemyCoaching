import { inject, Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { LoginActions } from '../actions/auth.actions';
import { AccountService } from '../../services/account-service';
import { catchError, map, of, switchMap } from 'rxjs';

@Injectable()
export class AuthEffects {
  private actions$ = inject(Actions);
  private accountService = inject(AccountService);

  submitLogin$ = createEffect(() =>
    this.actions$.pipe(
      ofType(LoginActions.submit),
      switchMap(({ credentials }) =>
        this.accountService.login(credentials).pipe(
          map((user) => LoginActions.success({ user })),
          catchError((error) => of(LoginActions.failure({ error })))
        )
      )
    )
  );

  logout$ = createEffect(
    () =>
      this.actions$.pipe(
        ofType(LoginActions.logout),
        map(() => this.accountService.logout())
      ),
    { dispatch: false }
  );
}
