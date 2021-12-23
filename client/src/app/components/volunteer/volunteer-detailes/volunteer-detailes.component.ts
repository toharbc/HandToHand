import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HelpRequests } from '../../../shared/models/HelpRequests.model';
import { TypeOfVolunteering } from '../../../shared/models/TypeOfVolunteering.model';
import { TypeOfVolunteeringService } from '../../../shared/services/type-of-volunteering.service';

@Component({
  selector: 'app-volunteer-detailes',
  templateUrl: './volunteer-detailes.component.html',
  
  styleUrls: ['./volunteer-detailes.component.css']
})
export class VolunteerDetailesComponent implements OnInit {
  typesOfVolunteering:TypeOfVolunteering[]=[]
  //codeSelect:number
  helpRequest : HelpRequests = new HelpRequests();
  constructor(  private typeOfVolenteeringService: TypeOfVolunteeringService,
    private router:Router) { }

  ngOnInit(): void {
    this.getsv()
  }

  getsv(){
    this.typeOfVolenteeringService.getAllTypeOfVolunteerings().subscribe(c=>
      {(this.typesOfVolunteering)=c;
      console.log(this.typesOfVolunteering)
    });

  }
  myRequest(){
    this.router.navigate([ 'app-my-request'])
  }
}
