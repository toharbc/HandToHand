import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Users } from 'src/app/shared/models/Users.model';
import { RoutingService } from 'src/app/shared/services/routing.service';
import { UsersService } from 'src/app/shared/services/users.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user:Users=new Users();
  constructor(private userService:UsersService,
     private routingService:RoutingService,
     private router:Router
     ) { }

  ngOnInit(): void {
  }

  register()
  {
    console.log(this.user)
    this.userService.addUser(this.user).subscribe(
      res=> {
        this.router.navigate([this.routingService.NextRoute])
      },
      err=>console.error(err)
      );
    
  }

}
