import { Component, OnInit } from '@angular/core';
import { RoutingService } from 'src/app/shared/services/routing.service';

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html',
  styleUrls: ['./welcome.component.css']
})
export class WelcomeComponent implements OnInit {

  constructor(public routingService:RoutingService) { }

  saveNextRoute(route:string)
  {
    this.routingService.NextRoute=route;
  }

  ngOnInit(): void {
  }



}
