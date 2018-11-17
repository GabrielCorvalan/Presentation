import {MatCheckboxModule, MatToolbarModule, MatIconModule, MatListModule,
        MatTableModule, MatFormFieldModule, MatButtonToggleModule, MatIcon, MatSnackBarModule,
        MatCardModule, MatGridListModule, MatSelectModule, MatOptionModule, MatNativeDateModule, MatDialogModule} from '@angular/material';

// import {MatDatepickerModule, MatDatepickerToggle} from '@angular/material/datepicker';
import { NgModule } from '@angular/core';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import {MatDatepickerModule} from '@angular/material/datepicker';

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
            MatSnackBarModule,
            MatCardModule,
            MatGridListModule,
            MatSelectModule,
            MatOptionModule,
            MatNativeDateModule, MatDialogModule],

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
            MatButtonModule,
            MatSnackBarModule,
            MatCardModule,
            MatGridListModule,
            MatSelectModule,
            MatOptionModule,
            MatNativeDateModule, MatDialogModule],
})
export class MaterialModule { }
