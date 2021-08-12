import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NewHelpRequestComponent } from './components/help-request/new-help-request/new-help-request.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { WelcomeComponent } from './components/shared/welcome/welcome.component';

const routes: Routes = [
  {path:'welcome' , component:WelcomeComponent},
  {path:'register', component:RegisterComponent},
  {path:'new-help-request', component:NewHelpRequestComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
