import { Component, inject } from '@angular/core';
import { DemoAccountService } from '../services/demo-account-service';
import { DemoNavBarComponent } from '../demo-nav-bar/demo-nav-bar.component';


@Component({
  selector: 'app-client-portal-home',
  imports: [DemoNavBarComponent],
  templateUrl: './client-portal-home.component.html',
  styleUrl: './client-portal-home.component.css'
})
export class ClientPortalHomeComponent {
  accountService = inject(DemoAccountService);
}

