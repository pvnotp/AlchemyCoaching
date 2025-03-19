import { Routes } from '@angular/router';
import { DemoHomeComponent } from './demo-home/demo-home.component';
import { HomeComponent } from './home/home.component';



export const routes: Routes = [
  { path: 'demo', component: DemoHomeComponent },
  { path: '', component: HomeComponent },
  { path: '**', component: HomeComponent, pathMatch: 'full' }
]
