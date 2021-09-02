import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HelpRequests } from '../models/HelpRequests.model';
@Injectable({
  providedIn: 'root'
})
export class HelpRequestsService {

  constructor(public http:HttpClient) { }
  AddHelpRequest(HelpRequests: HelpRequests)
  {
    return this.http.post(environment.serverUrl+'HelpRequests',HelpRequests)
  }
}
