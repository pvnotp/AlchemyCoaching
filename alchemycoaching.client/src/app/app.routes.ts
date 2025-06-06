import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ServicesComponent } from './services/services.component';
import { CoachesComponent } from './coaches/coaches.component';



export const routes: Routes = [
  { path: 'services', component: ServicesComponent },
  { path: 'coaches', component: CoachesComponent },
  { path: '', component: HomeComponent },
  { path: '**', component: HomeComponent, pathMatch: 'full' }
]
