import { MateersComponent } from './components/mateers/mateers.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { routing, appRoutingProviders } from './app.routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { StudentComponent } from './components/student/student.component';
import { UserComponent } from './components/user/user.component';
import { HomeComponent } from './components/home/home.component';
import { HttpClientModule } from '@angular/common/http';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { MaterialModule } from './../material.module';

// Animations
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { StudentEditComponent } from './components/student/student-edit/student-edit.component';
import { LoginComponent } from './components/login/login.component';
import { PlanMatersComponent } from './components/mateers/plan-maters/plan-maters.component';
import { MateersCreateOrUpdateComponent } from './components/mateers/mateers-create-or-update/mateers-create-or-update.component';
import { ExamComponent } from './components/exam/exam.component';
import { CorrelativityComponent } from './components/correlativity/correlativity.component';
import { CorrelativityAddComponent } from './components/correlativity/correlativity-add/correlativity-add.component';
import { ExamCreateOrUpdateComponent } from './components/exam/exam-create-or-update/exam-create-or-update.component';
import { UserCreateOrUpdateComponent } from './components/user/user-create-or-update/user-create-or-update.component';


@NgModule({
  declarations: [
    AppComponent,
    StudentComponent,
    UserComponent,
    HomeComponent,
    SidebarComponent,
    StudentEditComponent,
    LoginComponent,
    MateersComponent,
    PlanMatersComponent,
    MateersCreateOrUpdateComponent,
    ExamComponent,
    CorrelativityComponent,
    CorrelativityAddComponent,
    CorrelativityAddComponent,
    ExamCreateOrUpdateComponent,
    UserCreateOrUpdateComponent
  ],
  imports: [
    BrowserModule,
    routing,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MaterialModule
  ],
  providers: [appRoutingProviders],
  bootstrap: [AppComponent]
})
export class AppModule { }
