import { Component } from '@angular/core';
import { PagesEnum } from './pagesenum';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  activePage = PagesEnum.Home;
  navbarOpen = false;

  collapse(page: PagesEnum) {
    this.isExpanded = false;
    this.activePage = page;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }
}
