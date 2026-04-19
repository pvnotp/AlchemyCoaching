
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideHttpClient } from '@angular/common/http';
import { ApplicationConfig } from '@angular/core';
import { provideStore } from '@ngrx/store';
import { authFeatureKey, authReducer } from './store/reducers/auth.reducer';
import { provideEffects } from '@ngrx/effects';
import { AuthEffects } from './store/effects/auth.effects';


export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes),
    provideHttpClient(),
    provideStore({
      [authFeatureKey]: authReducer
    }),
    provideEffects([AuthEffects])
  ]
};
