import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule}from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { WelcomeComponent } from './components/shared/welcome/welcome.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { NewHelpRequestComponent } from './components/requester/new-help-request/new-help-request.component';
import { MyRequestComponent } from './components/volunteer/my-request/my-request.component';
import { RequesterRequestsComponent } from './components/requester/requester-requests/requester-requests.component';
import { LoginComponent } from './components/shared/login/login.component';
import { VolunteerDetailesComponent } from './components/volunteer/volunteer-detailes/volunteer-detailes.component';


@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    RegisterComponent,
    NewHelpRequestComponent,
    MyRequestComponent,
    RequesterRequestsComponent,
    LoginComponent,
    VolunteerDetailesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
