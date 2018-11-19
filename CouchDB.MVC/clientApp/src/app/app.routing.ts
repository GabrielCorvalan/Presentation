import { MateersCreateOrUpdateComponent } from './components/mateers/mateers-create-or-update/mateers-create-or-update.component';
import { PlanMatersComponent } from './components/mateers/plan-maters/plan-maters.component';
import { LoginComponent } from './components/login/login.component';
import { StudentEditComponent } from './components/student/student-edit/student-edit.component';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { StudentComponent } from './components/student/student.component';
import { UserComponent } from '../app/components/user/user.component';
import { HomeComponent } from '../app/components/home/home.component';
import { MateersComponent } from './components/mateers/mateers.component';
import { ExamComponent } from './components/exam/exam.component';
import { ExamCreateOrUpdateComponent } from './components/exam/exam-create-or-update/exam-create-or-update.component';
import { UserCreateOrUpdateComponent } from './components/user/user-create-or-update/user-create-or-update.component';
import { CorrelativityComponent } from './components/correlativity/correlativity.component';
import { CorrelativityAddComponent } from './components/correlativity/correlativity-add/correlativity-add.component';

const appRoutes: Routes = [
  { path: '', component: LoginComponent },
  // login
  { path: 'login', component: LoginComponent },
  // Home
  { path: 'home', component: HomeComponent },
  // Users
  { path: 'user', component: UserComponent },
  { path: 'user/create-or-update', component: UserCreateOrUpdateComponent, children: [
    { path: ':id', component: UserCreateOrUpdateComponent }
  ]},
  // students
  { path: 'student', component: StudentComponent},
  { path: 'student/edit', component: StudentEditComponent, children: [
    { path: ':id', component: StudentEditComponent }
  ]},
  // materias
  { path: 'mateers', component: MateersComponent, children: [
  ]},
  { path: 'mateers/planMateers', component: PlanMatersComponent},
  { path: 'mateers/create-or-update', component: MateersCreateOrUpdateComponent, children: [
    { path: ':id', component: MateersCreateOrUpdateComponent }
  ]},
  // exams
  { path: 'exams', component: ExamComponent },
  { path: 'exams/create-or-update', component: ExamCreateOrUpdateComponent, children: [
    { path: ':id', component: ExamCreateOrUpdateComponent }
  ] },
  // Correlatividad
  { path: 'correlativity', component: CorrelativityComponent },
  { path: 'correlativity/add', component: CorrelativityAddComponent, children: [
    { path: ':id', component: CorrelativityAddComponent }
  ]}
];

export const appRoutingProviders: any[] = [];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);

