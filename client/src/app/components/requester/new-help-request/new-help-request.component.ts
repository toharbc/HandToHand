import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HelpRequests } from '../../../shared/models/HelpRequests.model';
import { TypeOfVolunteering } from '../../../shared/models/TypeOfVolunteering.model';
import { HelpRequestsService } from '../../../shared/services/help-requests.service';
import { TypeOfVolunteeringService } from '../../../shared/services/type-of-volunteering.service';

@Component({
  selector: 'new-help-request',
  templateUrl: './new-help-request.component.html',
  styleUrls: ['./new-help-request.component.css']
})
export class NewHelpRequestComponent implements OnInit {

  helpRequest : HelpRequests = new HelpRequests();
  typesOfVolunteering:TypeOfVolunteering[]=[];
  isShowFind: boolean = false;

  constructor(private helpRequestService:HelpRequestsService,
    private typeOfVolenteeringService: TypeOfVolunteeringService,
    private router:Router) { }

  ngOnInit(): void {
     this.typeOfVolenteeringService.getAllTypeOfVolunteerings().subscribe(
      res=>{this.typesOfVolunteering=res;console.log(this.typesOfVolunteering)}
    );
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
    this.router.navigate(['/requester-requests'])
  }
  findVolunteer(){
    // this.router.navigate(['/find'])
    
    // if (this.helpRequest.TypeOfVolunteerId != null && 
    //   this.helpRequest.StartHour != null &&
    //   this.helpRequest.EndHour != null) {
        this.isShowFind = true;
      // }
      
  }

 
}

 
