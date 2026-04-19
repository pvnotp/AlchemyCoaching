import { Component, HostListener, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink, Router, NavigationStart } from '@angular/router';
import { LoginComponent } from '../login/login.component';
import { Subscription } from 'rxjs';
import { Store } from '@ngrx/store';
import { selectUser } from '../../store/selectors/auth.selectors';
import { LoginActions } from '../../store/actions/auth.actions';

@Component({
  selector: 'app-nav-bar',
  standalone: true,
  imports: [FormsModule, RouterLink, LoginComponent],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.scss'
})
export class NavBarComponent {

  private store = inject(Store);
  user = this.store.selectSignal(selectUser);
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

  toggleDropdownMenu() {
    this.showDropdownMenu = !this.showDropdownMenu;
  }

  togglePortalMenu() {
    this.showPortalMenu = !this.showPortalMenu;
  }

  logout() {
    this.store.dispatch(LoginActions.logout());
    this.showPortalMenu = false;
  }

  ngOnDestroy(): void {
    this.routerSubscription.unsubscribe();
  }
}
