import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { Home2Component } from './home-2/home-2.component';



export const routes: Routes = [
  { path: '', component: Home2Component },
  { path: '**', component: Home2Component, pathMatch: 'full' }
]
