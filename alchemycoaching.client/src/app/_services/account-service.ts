import { HttpClient } from '@angular/common/http';
import { Injectable, inject, signal } from '@angular/core';
import { map, mergeMap } from 'rxjs';
import { environment } from '../../environments/environment'


export interface userLogin {
  email: string | null;
  password: string | null;
}

export interface token {
  accessToken: string;
  expiresIn: number;
  refreshToken: string;
}

export interface user {
  email: string;
  password: string;
  name: string;
}

@Injectable({
  providedIn: 'root',
})

export class AccountService {
  private http = inject(HttpClient);
  baseUrl = environment.apiUrl;
  currentUser = signal<user | null>(null);


  setToken(userLogin: userLogin) {
    return this.http.post<token>(this.baseUrl + 'users/login', userLogin).pipe(
      map((token) => {
        if (token) {
          localStorage.setItem('token', JSON.stringify(token));
        }
      })
    );
  }

  setUser(userLogin: userLogin) {
    return this.http.get<user>(this.baseUrl + 'users/' + userLogin.email).pipe(
      map((user) => {
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUser.update(() => user);
        }
      })
    );
  }
     

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.currentUser.set(null);
  }
}
