import { LoginComponent } from './components/login/login.component';
import { StudentEditComponent } from './student/student-edit/student-edit.component';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { StudentComponent } from '../app/student/student.component';
import { UserComponent } from '../app/components/user/user.component';
import { HomeComponent } from '../app/components/home/home.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'home', component: HomeComponent },
  { path: 'user', component: UserComponent },
  { path: 'student', component: StudentComponent},
  { path: 'student/edit', component: StudentEditComponent, children: [
    { path: ':id', component: StudentEditComponent }
  ]}
];

export const appRoutingProviders: any[] = [];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);

