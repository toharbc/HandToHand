import { Component, OnInit } from '@angular/core';
import { HelpRequests } from '../../../shared/models/HelpRequests.model';
import { HelpRequestsService } from '../../../shared/services/help-requests.service';

@Component({
  selector: 'app-requester-requests',
  templateUrl: './requester-requests.component.html',
  styleUrls: ['./requester-requests.component.css']
})
export class RequesterRequestsComponent implements OnInit {

  helpRequests:HelpRequests[]=[];
  constructor(private helpRequestService:HelpRequestsService) { }

  ngOnInit(): void {
    this.helpRequestService.getHelpRequestsByRequesterId(0).subscribe(
      res=>this.helpRequests=res
    )
  }

}
