import { Component, HostListener, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../services/account-service';
import { RouterLink } from '@angular/router';
import { LoginComponent } from '../login/login.component';

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
    document.getElementById("login-popover")?.hidePopover();
    document.getElementById("client-portal-menu")?.classList.remove("hide");
    document.getElementsByClassName("top-nav")[0].classList.add("dropdown");
  }

  toggleMenu() {
    document.getElementsByClassName("top-nav")[0].classList.toggle("dropdown");
  }

  togglePortalMenu() {
    document.getElementById("client-portal-menu")?.classList.toggle("hide");
  }

  logout() {
    this.accountService.logout();
    document.getElementById("client-portal-menu")?.classList.add("hide");
  }
}
