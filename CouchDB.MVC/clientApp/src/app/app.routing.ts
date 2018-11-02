import { StudentEditComponent } from './student/student-edit/student-edit.component';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { StudentComponent } from '../app/student/student.component';
import { UserComponent } from '../app/user/user.component';
import { HomeComponent } from '../app/home/home.component';
import { NavbarComponent } from './navbar/navbar.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'home', component: HomeComponent },
  { path: 'user', component: UserComponent },
  { path: 'student', component: StudentComponent},
  { path: 'student/edit', component: StudentEditComponent, children: [
    { path: ':id', component: StudentEditComponent }
  ]}
];

export const appRoutingProviders: any[] = [];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);

