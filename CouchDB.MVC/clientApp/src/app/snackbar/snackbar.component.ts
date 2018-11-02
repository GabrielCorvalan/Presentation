import { Component } from '@angular/core';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-snackbar',
  template: `
    <p>
      snackbar works!
    </p>
  `,
  styles: []
})
export class SnackbarComponent {

  constructor(public snackBar: MatSnackBar) { }

}
