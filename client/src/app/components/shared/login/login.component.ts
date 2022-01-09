import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RoutingService } from '../../../shared/services/routing.service';
import { UsersService } from '../../../shared/services/users.service';


@Component({
  selector: 'login',
  templateUrl:'./login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  mail:string=''
  password:string=''
  constructor(private userService:UsersService,
    private routingService:RoutingService,
    private router:Router
    ) { }

  ngOnInit(): void {
  }

  login()
  {
    this.userService.login(this.mail,this.password).subscribe(
      res=> {
        sessionStorage.setItem('user',res.toString())
        this.router.navigate([this.routingService.NextRoute])
      },
    )
  }
  needhelpSpace(){
    this.router.navigate(['/needhelp-space'])
  } 
  mitnadevSpace(){
    this.router.navigate(['/mitnadev-space'])
  }
}
