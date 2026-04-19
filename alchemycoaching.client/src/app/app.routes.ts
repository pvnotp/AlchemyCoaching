import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ServicesComponent } from './components/services/services.component';
import { CoachesComponent } from './components/coaches/coaches.component';
import { ScheduleComponent } from './components/schedule/schedule.component';



export const routes: Routes = [
  { path: 'services', component: ServicesComponent },
  { path: 'coaches', component: CoachesComponent },
  { path: 'schedule', component: ScheduleComponent },
  { path: '', component: HomeComponent },
  { path: '**', component: HomeComponent, pathMatch: 'full' }
]
