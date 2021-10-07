import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http';
import {Users} from './../models/Users.model'
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(public http:HttpClient) { }

  addUser(user:Users)
  {
    return this.http.post(environment.serverUrl+'users',user)
  }

  login(mail:string,password:string)
  {
    return this.http.get(`${environment.serverUrl}users/Login?mail=${mail}&password=${password}`)
  }
 

}
