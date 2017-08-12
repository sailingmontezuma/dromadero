import { Component, ElementRef, HostBinding, HostListener,
  Input, OnInit, Renderer,
  trigger, state, style, transition, animate } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

import { MenuItem, MenuService } from '../../services/menu.service';


@Component({
  selector: 'fw-menu-item',
  templateUrl: './menu-item.component.html',
  styleUrls: ['./menu-item.component.css']
})
export class MenuItemComponent implements OnInit {
  @Input() item = <MenuItem>null;  // see angular-cli issue #2034

  isActiveRoute = false;
  mouseInItem = false;
  mouseInPopup = false;
  popupLeft = 0;
  popupTop = 34;

  constructor(private router: Router, private menuService: MenuService,
              private el: ElementRef, private renderer: Renderer) {  }

  ngOnInit() {
  }

}
