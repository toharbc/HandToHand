import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HelpRequests } from 'src/app/shared/models/HelpRequests.model';
import { VolunteeringForUsers } from 'src/app/shared/models/VolunteeringForUsers.model';
import { HelpRequestsService } from 'src/app/shared/services/help-requests.service';

@Component({
  selector: 'find',
  templateUrl: './find.component.html',
  styleUrls: ['./find.component.css']
})
export class FindComponent implements OnInit {

  @Input() helpRequest: HelpRequests = new HelpRequests();
  volunteers: VolunteeringForUsers[] = [];

  constructor( private router:Router, private helpRequesService: HelpRequestsService) { }

  ngOnInit(): void {
  }

  ngOnChanges(): void {
    this.getVolunteersForHelpRequest();
    console.log(this.helpRequest);
  }

  getVolunteersForHelpRequest()
  {
    this.helpRequesService.getVolunteersForHelpRequest(this.helpRequest)
    .subscribe(list => this.volunteers = list, 
      err => console.log(err));
  }

}
