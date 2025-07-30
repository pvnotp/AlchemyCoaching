import { HttpClient } from '@angular/common/http';
import { Injectable, inject, signal } from '@angular/core';
import { concat, finalize, map, mergeMap, switchMap } from 'rxjs';
import { environment } from '../../environments/environment'



export interface userLogin {
  email: string;
  password: string;
}

export interface token {
  accessToken: string;
  expiresIn: number;
  refreshToken: string;
}


export interface user {
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

  getUser(userLogin: userLogin) {
    return this.http.get<user>(this.baseUrl + 'users/' + userLogin.email).pipe(
      map((user) => {
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUser.update(() => user);
        }
      })
    );
  }

  login(userLogin: userLogin) {
    return concat(
      this.setToken(userLogin),
      this.getUser(userLogin)
    );
  }

  registerUser(userLogin: userLogin, name: string) {
    return concat(
      this.http.post(this.baseUrl + 'users/register', userLogin),
      this.http.get<user>(this.baseUrl + 'users/' + userLogin.email)
        .pipe(switchMap(
          user => this.updateUserName(user, name)
      ))
    );
  }

  updateUserName(user: user, username: string) {
    user.userName = username;
    user.normalizedUserName = username.toLowerCase();
    console.log("hello");
    return this.http.put(this.baseUrl + 'users/' + user.id, user);
  }


  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.currentUser.set(null);
  }
}
