import { Component, OnInit } from '@angular/core';
import { HelpRequests } from 'src/app/shared/models/HelpRequests.model';
import { HelpRequestsService } from 'src/app/shared/services/help-requests.service';

@Component({
  selector: 'app-new-help-request',
  templateUrl: './new-help-request.component.html',
  styleUrls: ['./new-help-request.component.css']
})
export class NewHelpRequestComponent implements OnInit {

  helpRequest : HelpRequests = new HelpRequests();
  constructor(private helpRequestService:HelpRequestsService) { }

  ngOnInit(): void {
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

 
