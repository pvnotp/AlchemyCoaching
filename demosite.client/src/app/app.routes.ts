import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { Home2Component } from './home-2/home-2.component';
import { OurServicesComponent } from './our-services/our-services.component';
import { OurCoachesComponent } from './our-coaches/our-coaches.component';



export const routes: Routes = [
  { path: 'services', component: OurServicesComponent },
  { path: 'coaches', component: OurCoachesComponent },
  { path: '', component: Home2Component },
  { path: '**', component: Home2Component, pathMatch: 'full' }
]
