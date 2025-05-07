import { Routes } from '@angular/router';
import { ClientPortalHomeComponent } from './client-portal-home/client-portal-home.component';
import { HomeComponent } from './home/home.component';



export const routes: Routes = [
  { path: 'client-portal-home', component: ClientPortalHomeComponent },
  { path: '', component: HomeComponent },
  { path: '**', component: HomeComponent, pathMatch: 'full' }
]
