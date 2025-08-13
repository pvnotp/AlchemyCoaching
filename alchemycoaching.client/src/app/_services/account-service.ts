import { HttpClient } from '@angular/common/http';
import { Injectable, inject, signal } from '@angular/core';
import { concat, map, switchMap } from 'rxjs';
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

export class AccountService {
  private http = inject(HttpClient);
  baseUrl = environment.apiUrl;
  currentUser = signal<User | null>(null);


  setToken(userLogin: UserLogin) {
    return this.http.post<Token>(this.baseUrl + 'users/login', userLogin).pipe(
      map((token) => {
        if (token) {
          localStorage.setItem('token', JSON.stringify(token));
        }
      })
    );
  }

  getUser(userLogin: UserLogin) {
    return this.http.get<User>(this.baseUrl + 'users/' + userLogin.email).pipe(
      map((user) => {
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUser.update(() => user);
        }
      })
    );
  }

  login(userLogin: UserLogin) {
    return concat(
      this.setToken(userLogin),
      this.getUser(userLogin)
    );
  }

  registerUser(userLogin: UserLogin, name: string) {
    return concat(
      this.http.post(this.baseUrl + 'users/register', userLogin),
      this.http.get<User>(this.baseUrl + 'users/' + userLogin.email)
        .pipe(switchMap(
          user => this.updateUserName(user, name)
      ))
    );
  }

  updateUserName(user: User, username: string) {
    user.userName = username;
    user.normalizedUserName = username.toLowerCase();
    return this.http.put(this.baseUrl + 'users/' + user.id, user);
  }


  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.currentUser.set(null);
  }
}
