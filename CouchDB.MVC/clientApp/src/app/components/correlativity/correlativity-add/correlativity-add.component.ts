import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-correlativity-add',
  templateUrl: './correlativity-add.component.html',
  styles: []
})
export class CorrelativityAddComponent implements OnInit {
  tittle: string;
  constructor(
    public dialogRef: MatDialogRef<CorrelativityAddComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any) {}

  ngOnInit() {
    this.tittle = this.data.tittle;
  }


}
