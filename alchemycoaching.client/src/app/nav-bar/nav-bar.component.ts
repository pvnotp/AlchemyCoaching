import { Component, HostListener, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../_services/account-service';
import { RouterLink, Router, NavigationStart } from '@angular/router';
import { LoginComponent } from '../login/login.component';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-nav-bar',
  standalone: true,
  imports: [FormsModule, RouterLink, LoginComponent],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.scss'
})
export class NavBarComponent {

  accountService = inject(AccountService);
  screenWidth = window.innerWidth;
  routerSubscription: Subscription;
  showDropdownMenu: boolean = false;
  showPortalMenu: boolean = false;

  constructor(private router: Router) {
    this.routerSubscription = this.router.events.subscribe(event => {
      if (event instanceof NavigationStart) {
        this.showDropdownMenu = false;
      }
    });
  }


  ngOnInit() {
    this.getScreenWidth();
  }

  @HostListener('window:resize', ['$event'])
  onResize(event: any) {
    this.getScreenWidth();
  }

  getScreenWidth() {
    this.screenWidth = window.innerWidth;
  }

  onLoginSuccess() {
    this.showPortalMenu = true;
  }

  toggleDropdownMenu() {
    this.showDropdownMenu = !this.showDropdownMenu;
  }

  togglePortalMenu() {
    this.showPortalMenu = !this.showPortalMenu;
  }

  logout() {
    this.accountService.logout();
    this.showPortalMenu = false;
  }

  ngOnDestroy(): void {
    this.routerSubscription.unsubscribe();
  }
}
