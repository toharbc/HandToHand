import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class TypeOfVolunteeringService {

  constructor(public http:HttpClient) { }
}
