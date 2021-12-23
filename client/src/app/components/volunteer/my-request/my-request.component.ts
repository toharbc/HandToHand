import { Component, OnInit } from '@angular/core';
import { HelpRequests } from '../../../shared/models/HelpRequests.model';


import { RequestsForVolunteer } from '../../../shared/models/RequestsForVolunteer.model';
import { HelpRequestsService } from '../../../shared/services/help-requests.service';
import { RequestsForVolunteerService } from '../../../shared/services/requests-for-volunteer.service';

@Component({
  selector: 'app-my-request',
  templateUrl: './my-request.component.html',
  styleUrls: ['./my-request.component.css']
})
export class MyRequestComponent implements OnInit {

  helpRequests:HelpRequests[]=[];
  constructor(private helpRequestService:HelpRequestsService) { }

  ngOnInit(): void {
    let userId:number=Number(sessionStorage.getItem('user'))
    this.helpRequestService.getHelpRequestsByVolenteerId(userId).subscribe(
      res=>this.helpRequests=res
    )
  }

   
 

}
