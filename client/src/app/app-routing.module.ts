import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NewHelpRequestComponent } from './components/requester/new-help-request/new-help-request.component';
import { LoginComponent } from './components/shared/login/login.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { WelcomeComponent } from './components/shared/welcome/welcome.component';
import { VolunteerDetailesComponent } from './components/volunteer/volunteer-detailes/volunteer-detailes.component';

const routes: Routes = [
  {path:'' , component:WelcomeComponent},
  {path:'welcome' , component:WelcomeComponent},
  {path:'register', component:RegisterComponent},
  {path:'login', component:LoginComponent},
  {path:'new-help-request', component:NewHelpRequestComponent},
  {path:'volunteer', component:VolunteerDetailesComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
