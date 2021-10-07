import { Component, OnInit } from '@angular/core';
import { HelpRequests } from 'src/app/shared/models/HelpRequests.model';
import { TypeOfVolunteering } from 'src/app/shared/models/TypeOfVolunteering.model';
import { HelpRequestsService } from 'src/app/shared/services/help-requests.service';
import { TypeOfVolunteeringService } from 'src/app/shared/services/type-of-volunteering.service';

@Component({
  selector: 'app-new-help-request',
  templateUrl: './new-help-request.component.html',
  styleUrls: ['./new-help-request.component.css']
})
export class NewHelpRequestComponent implements OnInit {

  helpRequest : HelpRequests = new HelpRequests();
  typesOfVolunteering:TypeOfVolunteering[]=[]
  constructor(private helpRequestService:HelpRequestsService,
    private typeOfVolenteeringService: TypeOfVolunteeringService) { }

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
  

}

 
