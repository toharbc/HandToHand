import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HelpRequests } from '../../../shared/models/HelpRequests.model';
import { TypeOfVolunteering } from '../../../shared/models/TypeOfVolunteering.model';
import { HelpRequestsService } from '../../../shared/services/help-requests.service';
import { TypeOfVolunteeringService } from '../../../shared/services/type-of-volunteering.service';

@Component({
  selector: 'app-new-help-request',
  templateUrl: './new-help-request.component.html',
  styleUrls: ['./new-help-request.component.css']
})
export class NewHelpRequestComponent implements OnInit {

  helpRequest : HelpRequests = new HelpRequests();
  typesOfVolunteering:TypeOfVolunteering[]=[]
  constructor(private helpRequestService:HelpRequestsService,
    private typeOfVolenteeringService: TypeOfVolunteeringService,
    private router:Router) { }

  ngOnInit(): void {
     this.typeOfVolenteeringService.getAllTypeOfVolunteerings().subscribe(
      res=>this.typesOfVolunteering=res
    )
  }


  
  newHelpRequest()
  {
    console.log(this.helpRequest)
    this.helpRequestService.AddHelpRequest(this.helpRequest).subscribe(
      res=>console.log(res),
      err=>console.error(err)
      );
    
  }
  requesterRequests(){
    this.router.navigate([ 'app-requester-requests'])
  }
  findVolunteer(){
    this.router.navigate([ 'app-find'])
  }

 
}

 
