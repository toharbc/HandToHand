import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { RoutingService } from './shared/services/routing.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-app';
  isdisable:boolean=true
  
  constructor(private router:Router,
    public routingService:RoutingService,){}
  
  ngOnInit(): void {
  }
  
  mitnadev()
  {
  //this.isdisable=false
  this.router.navigate(['/mitnadev'])
  }
  needHelp() 
  {
 // this.isdisable=false
  this.router.navigate(['/need-help'])
  
  }
}


