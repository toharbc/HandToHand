import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { VolunteeringForUsersService } from '../../../shared/services/volunteering-for-users.service';
import { Router } from "@angular/router";


@Component({
  selector: 'profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  
  constructor(private volunteeringForUsersService:VolunteeringForUsersService,
    private route:ActivatedRoute,
    private router:Router 
    ) { }

    volunteeringId:number=0;
  ngOnInit(): void {
    this.route.params.subscribe(p=>{
      this.volunteeringId=p.id;
      this.getProfile();
    })
  }
    getProfile()
    {
          
    }
    register(){
      this.router.navigate([ '/register'])
    }
  }
  
  



