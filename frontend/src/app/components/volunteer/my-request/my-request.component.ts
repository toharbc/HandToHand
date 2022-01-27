import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, Subject } from 'rxjs';
import { TypeOfVolunteeringService } from 'src/app/shared/services/type-of-volunteering.service';
import { UsersService } from 'src/app/shared/services/users.service';
import { HelpRequests } from '../../../shared/models/HelpRequests.model';


import { RequestsForVolunteer } from '../../../shared/models/RequestsForVolunteer.model';
import { HelpRequestsService } from '../../../shared/services/help-requests.service';
import { RequestsForVolunteerService } from '../../../shared/services/requests-for-volunteer.service';

export class FullHelpRequest {
 Id?: number;
  UserName?: string;
  TypeOfVolunteering?: string;
  StartDate?: Date;
  EndDate?: Date;
  StartHour?: string;
  EndHour?: string;

}

@Component({
  selector: 'my-request',
  templateUrl: './my-request.component.html',
  styleUrls: ['./my-request.component.css']
})
export class MyRequestComponent implements OnInit {

  helpRequests: HelpRequests[] = [];
  fullHelpRequests: FullHelpRequest[] = [];
  constructor(private helpRequestService: HelpRequestsService,
    public route: Router,
    private userService: UsersService,
    private typeOfVolunteeringService: TypeOfVolunteeringService
  ) { }

  ngOnInit(): void {
    let userId: number = Number(sessionStorage.getItem('user'))
    this.helpRequestService.getHelpRequestsByVolenteerId(userId).subscribe(
      res => {
        this.helpRequests = res;
        this.convertToFullHelpRequest(res);
      }
    )
  }
  
  reject(item: FullHelpRequest) {
    // פונקציה שקוראת כשהמתנדב בוחר לדחות
  }

  confirm(item: FullHelpRequest) {
    // פונקציה שקוראת כשהמתנדב בוחר לאשר
  }

    convertToFullHelpRequest(helpRequests: HelpRequests[]) {
    helpRequests.forEach(element => {
      let fullHelpRequest = new FullHelpRequest();
      fullHelpRequest.Id = element.HelpRequestId;
      // מביאים את השם של המשתמש לפי ההידי-המזהה
      this.getUserName(element.RequesterId)
        .subscribe(res => fullHelpRequest.UserName = res);
      // fullHelpRequest.userName = this.getUserName(element.RequesterId);
      // fullHelpRequest.typeOfVolunteering = this.getTypeOfVolunteering(element.TypeOfVolunteerId);
      // מביאים את השם של סוג ההתנדבות לפי המזהה
      this.getTypeOfVolunteering(element.TypeOfVolunteerId)
      .subscribe(res => fullHelpRequest.TypeOfVolunteering = res);
      fullHelpRequest.StartDate = element.StartDate;
      fullHelpRequest.EndDate = element.EndDate;
      fullHelpRequest.StartHour = element.StartHour;
      fullHelpRequest.EndHour = element.EndHour;
      this.fullHelpRequests.push(fullHelpRequest);
    });
  }

  getUserName(userId?: number): Observable<string> {
    let userName = '';
    let subject = new Subject<string>();
    if (userId != undefined) {
      this.userService.getUser(userId)
        .subscribe(res => {
          userName = res.UserFirstName + ' ' + res.UserLastName;
          subject.next(userName);
        });
    }
    return subject.asObservable();
  }

  getTypeOfVolunteering(typeId?: number): Observable<string> {
    let subject = new Subject<string>();
    if (typeId != undefined) {
      this.typeOfVolunteeringService.getTypeOfVolunteeringById(typeId)
        .subscribe(res => {
          subject.next(res.TypeOfVolunteeringName);
        });
    }
    return subject.asObservable();
  }



}
