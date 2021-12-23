import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FindComponent } from './components/requester/find/find.component';
import { GuestComponent } from './components/requester/guest/guest.component';
import { NewHelpRequestComponent } from './components/requester/new-help-request/new-help-request.component';
import { LoginComponent } from './components/shared/login/login.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { WelcomeComponent } from './components/shared/welcome/welcome.component';
import { ProfileComponent } from './components/volunteer/profile/profile.component';
import { VolunteerDetailesComponent } from './components/volunteer/volunteer-detailes/volunteer-detailes.component';

const routes: Routes = [
  {path:'' , component:WelcomeComponent},
  {path:'app-welcome' , component:GuestComponent},
  {path: 'app-register', component:RegisterComponent},
  {path:'app-login', component:LoginComponent},
  {path: 'app-new-help-request', component:NewHelpRequestComponent},
  {path:'app-new-help-request/:id', component:NewHelpRequestComponent},
  {path:'app-volunteer-detailes', component:VolunteerDetailesComponent},
  {path:'app-profile/:id', component:ProfileComponent},
  {path:'app-find', component:FindComponent},



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
