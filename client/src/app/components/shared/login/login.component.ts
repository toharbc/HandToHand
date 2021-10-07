import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RoutingService } from 'src/app/shared/services/routing.service';
import { UsersService } from 'src/app/shared/services/users.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
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

}
