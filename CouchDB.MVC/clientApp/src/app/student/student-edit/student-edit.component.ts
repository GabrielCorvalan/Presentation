import { StudentService } from './../student.service';
import { Component, OnInit } from '@angular/core';
import { IStudent } from '../../../Interfaces/IStudent';
import { MatSnackBar } from '@angular/material';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-student-edit',
  templateUrl: 'student-edit.component.html',
  styleUrls: ['student-edit.component.css']
})
export class StudentEditComponent implements OnInit {
  student: IStudent = {name: '', lastName: '', city: '', career: '', birthdate: new Date, _id: null, _rev: null };
  constructor(private studentService: StudentService,
              private _route: ActivatedRoute,
              public snackBar: MatSnackBar,
              private router: Router) { }

  ngOnInit() {
    if (this._route.snapshot.paramMap.get('id')) {
      const id = this._route.snapshot.paramMap.get('id');
      this.studentService.getStudentById(id).subscribe((res: IStudent) => {
        this.student = res;
        console.log(this.student);
      }, (error: any): void => {
        console.log(error);
      });
    }
  }

  onSubmit(): void {
    this.studentService.createStudent(this.student).subscribe(((res: boolean) => {
        if (res) {
          this.openSnackBar('Operacion exitosa', 'Success');
          this.router.navigateByUrl('/student');
        } else {
          this.openSnackBar('Error en la operacion', 'Error');
        }
      }),
      (error: any) => {
        this.openSnackBar('Error en la operacion', 'Error');
      });
  }

  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
      duration: 2000,
    });
  }

}
