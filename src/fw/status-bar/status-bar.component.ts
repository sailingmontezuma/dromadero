import { Component, OnInit } from '@angular/core';
import { ScreenService } from '../services/screen.service';


@Component({
  selector: 'fw-status-bar',
  templateUrl: './status-bar.component.html',
  styleUrls: ['./status-bar.component.css']
})
export class StatusBarComponent implements OnInit {

  constructor(private screenService: ScreenService) { }

  ngOnInit() {
  }

}
