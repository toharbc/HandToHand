import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HelpRequests } from '../models/HelpRequests.model';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class HelpRequestsService {

  constructor(public http:HttpClient) { }
  AddHelpRequest(HelpRequests: HelpRequests)
  {
    return this.http.post(environment.serverUrl+'HelpRequests',HelpRequests)
  }

  getHelpRequestsByVolenteerId(id:number):Observable<HelpRequests[]>
  {
    return this.http.get<HelpRequests[]>(environment.serverUrl+'HelpRequests/getHelpRequestsByVolenteerId/'+id)
  }

  getHelpRequestsByRequesterId(id:number):Observable<HelpRequests[]>
  {
    return this.http.get<HelpRequests[]>(environment.serverUrl+'HelpRequests/GetHelpRequestsByRequesterId/'+id)
  }

 


}
