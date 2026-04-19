import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { concat, switchMap, tap } from 'rxjs';
import { environment } from '../../environments/environment';


export interface UserLogin {
  email: string;
  password: string;
}

export interface Token {
  accessToken: string;
  expiresIn: number;
  refreshToken: string;
}


export interface User {
  id: string | null;
  email: string | null;
  normalizedEmail: string | null;
  userName: string | null;
  normalizedUserName: string | null;
  passwordHash: string | null;
  twoFactorEnabled: boolean | null;
  securityStamp: string | null;
  concurrencyStamp: string | null;
}

@Injectable({
  providedIn: 'root',
})

export class AuthService {
  private http = inject(HttpClient);
  baseUrl = environment.apiUrl;


  setToken(userLogin: UserLogin) {
    return this.http.post<Token>(this.baseUrl + 'users/login', userLogin).pipe(
      tap((token) => {
        if (token) {
          localStorage.setItem('token', JSON.stringify(token));
        }
      })
    );
  }

  getUser(email: string) {
    return this.http.get<User>(this.baseUrl + 'auth/' + email);
  }

  getUserRole(userId: string) {
    return this.http.get<string>(this.baseUrl + 'auth/' + userId + '/role');
  }

  login(userLogin: UserLogin) {
    return this.setToken(userLogin).pipe(
      switchMap(() => this.getUser(userLogin.email))
    );
  }
  
  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
  }
}
