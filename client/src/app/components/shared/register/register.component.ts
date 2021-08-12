import { Component, OnInit } from '@angular/core';
import { Users } from 'src/app/shared/models/Users.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user:Users=new Users();
  constructor() { }

  ngOnInit(): void {
  }

  register()
  {
    console.log(this.user)
  }

}
