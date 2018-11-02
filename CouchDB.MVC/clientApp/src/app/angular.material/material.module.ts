import {MatCheckboxModule, MatToolbarModule, MatIconModule, MatListModule,
        MatTableModule, MatFormFieldModule, MatButtonToggleModule, MatIcon, MatSnackBarModule} from '@angular/material';

import {MatDatepickerModule, MatDatepickerToggle} from '@angular/material/datepicker';
import { NgModule } from '@angular/core';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';

@NgModule({
  imports: [MatButtonModule,
            MatCheckboxModule,
            MatSidenavModule,
            MatToolbarModule,
            MatIconModule,
            MatListModule,
            MatProgressSpinnerModule,
            MatTableModule,
            MatFormFieldModule,
            MatInputModule,
            MatDatepickerModule,
            MatIconModule,
            MatButtonModule,
            MatSnackBarModule],

  exports: [MatButtonModule,
            MatCheckboxModule,
            MatSidenavModule,
            MatToolbarModule,
            MatIconModule,
            MatListModule,
            MatTableModule,
            MatProgressSpinnerModule,
            MatFormFieldModule,
            MatInputModule,
            MatDatepickerModule,
            MatDatepickerModule,
            MatButtonModule,
            MatSnackBarModule],
})
export class MaterialModule { }