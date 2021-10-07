import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http';
import { RequestsForVolunteer } from '../models/RequestsForVolunteer.model';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class RequestsForVolunteerService {

  constructor(public http:HttpClient) { }

  getAllRequestsForVolunteer():Observable<RequestsForVolunteer[]>
  {
    return this.http.get<RequestsForVolunteer[]>('');
  }
}
