import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { RoutingService } from '../../../shared/services/routing.service';
import { UsersService } from '../../../shared/services/users.service';
import { Users } from '../../../shared/models/Users.model';

@Component({
  selector: 'register',
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
        alert(res?'נרשמת למערכת בהצלחה'
        :'קרתה תקלה בהרשמה');
        this.router.navigate([this.routingService.NextRoute]);
      },
      err=>console.error(err)
      );
    
  }
  login(){
    this.router.navigate(['/login'])
  }
  //לקחת את הפונקציה מרות
  //כאן צריכה להעביר לפי המשתמש אם זה מתנדב להוספת התנדבות ואם מבקש עזרה להוספת בקשת עזרה
  insert(){
    this.router.navigate(['/new-help-request']) 
  }

}
