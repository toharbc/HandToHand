import { Component, OnInit } from '@angular/core';
import { Users } from 'src/app/shared/models/Users.model';
import { UsersService } from 'src/app/shared/services/users.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user:Users=new Users();
  constructor(private userService:UsersService) { }

  ngOnInit(): void {
  }

  register()
  {
    console.log(this.user)
    this.userService.addUser(this.user).subscribe(
      res=>console.log(res),
      err=>console.error(err)
      );
    
  }

}
