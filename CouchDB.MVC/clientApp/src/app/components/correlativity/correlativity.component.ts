import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialog } from '@angular/material';
import { CorrelativityAddComponent } from './correlativity-add/correlativity-add.component';

@Component({
  selector: 'app-correlativity',
  templateUrl: './correlativity.component.html',
  styles: []
})
export class CorrelativityComponent implements OnInit {

  myForm: FormGroup;
  constructor(public formBuild: FormBuilder,
              public dialog: MatDialog) { }

  ngOnInit() {
    this.loadForm();
  }

  loadForm(): void {
    this.myForm = this.formBuild.group({
      mateer: '',
      correlatives: this.formBuild.array([
        '', ''
      ])
    });
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(CorrelativityAddComponent, {
      width: '250px',
      data: {tittle: 'Hello Modal'}
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

}
