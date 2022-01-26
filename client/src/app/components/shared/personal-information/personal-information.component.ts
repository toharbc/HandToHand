import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Users } from 'src/app/shared/models/Users.model';
import { RoutingService } from 'src/app/shared/services/routing.service';
import { UsersService } from 'src/app/shared/services/users.service';

@Component({
  selector: 'personal-information',
  templateUrl: './personal-information.component.html',
  styleUrls: ['./personal-information.component.css']
})
export class PersonalInformationComponent implements OnInit {
  confirmPassword: string = '';

  user: Users = new Users();

  constructor(private router:Router, private userService: UsersService,
    private routingService: RoutingService,
    ) { 
    this.getUser();
  }

  ngOnInit(): void {
  }

  getUser() {
    let userId = sessionStorage.getItem("user");
    if (userId != undefined) {
      this.userService.getUser(Number(userId))
      .subscribe(res => this.user = res, 
        err=> console.log(err));
    }
  }
  update(){
    if (this.user.UserFirstName != undefined &&
      this.user.UserLastName != undefined &&
      this.user.UserAdress != undefined &&
      this.user.UserMail != undefined &&
      this.user.UserPhone != undefined) {
      if (this.user.UserPassword == this.confirmPassword) {
        this.userService.addUser(this.user).subscribe(
          res => {
            alert(res ? '  הפרטים עודכנו בהצלחה'
              : 'קרתה תקלה בעדכון');
            this.router.navigate([this.routingService.NextRoute]);
          },
          err => console.error(err)
        );
      }
      else {
        alert('הסיסמה לא תקינה');
      }
    }
    else {
      alert("חובה למלא את כל השדות");
    }

  }
  

  }


