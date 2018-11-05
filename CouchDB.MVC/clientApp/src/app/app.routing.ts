import { MateersCreateOrUpdateComponent } from './components/mateers/mateers-create-or-update/mateers-create-or-update.component';
import { PlanMatersComponent } from './components/mateers/plan-maters/plan-maters.component';
import { LoginComponent } from './components/login/login.component';
import { StudentEditComponent } from './student/student-edit/student-edit.component';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { StudentComponent } from '../app/student/student.component';
import { UserComponent } from '../app/components/user/user.component';
import { HomeComponent } from '../app/components/home/home.component';
import { MateersComponent } from './components/mateers/mateers.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  // login
  { path: 'login', component: LoginComponent },
  { path: 'home', component: HomeComponent },
  { path: 'user', component: UserComponent },
  // students
  { path: 'student', component: StudentComponent},
  { path: 'student/edit', component: StudentEditComponent, children: [
    { path: ':id', component: StudentEditComponent }
  ]},
  // materias
  { path: 'mateers', component: MateersComponent, children: [
  ]},
  {path: 'mateers/planMateers', component: PlanMatersComponent},
  {path: 'mateers/add', component: MateersCreateOrUpdateComponent},
  {path: 'mateers/edit', component: MateersCreateOrUpdateComponent}

  // teachers
];

export const appRoutingProviders: any[] = [];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);

