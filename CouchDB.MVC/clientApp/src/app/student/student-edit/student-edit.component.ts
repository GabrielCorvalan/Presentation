import { StudentService } from './../student.service';
import { Component, OnInit } from '@angular/core';
import { IStudent } from '../../Interfaces/IStudent';
import { MatSnackBar } from '@angular/material';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { Student } from 'src/app/Classes/student';

@Component({
  selector: 'app-student-edit',
  templateUrl: 'student-edit.component.html',
  styleUrls: ['student-edit.component.css']
})
export class StudentEditComponent implements OnInit {
  student: IStudent;
  formGroup: FormGroup;
  constructor(private studentService: StudentService,
    private _route: ActivatedRoute,
    public snackBar: MatSnackBar,
    private router: Router,
    private fb: FormBuilder) { }

    ngOnInit() {
      this.loadForm();
      this.getStudentByUrl();
    }
    // Si viene el id se hace un update
    getStudentByUrl(): void {
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

    loadForm(): void {
      this.formGroup = this.fb.group({
        firstName: '',
        lastName: '',
        dni: '',
        birthdate: new Date(),
        cuil: '',
        age: null,
        address: ''
      });
      // this.formGroup = this.fb.group({
      //   firstName: [this.student.firstName, []],
      //   lastName: [this.student.lastName, []],
      //   dni: [this.student.dni, []],
      //   birthdate: [this.student.birthdate, []],
      //   cuil: [this.student.cuil, []]
      // });
    }

    onSubmit(): void {
      console.log(this.formGroup.value);
      // this.studentService.createStudent(this.student).subscribe(((res: boolean) => {
        //     if (res) {
          //       this.openSnackBar('Operacion exitosa', 'Success');
          //       this.router.navigateByUrl('/student');
          //     } else {
            //       this.openSnackBar('Error en la operacion', 'Error');
    //     }
    //   }),
    //   (error: any) => {
    //     this.openSnackBar('Error en la operacion', 'Error');
    //   });
  }

  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
      duration: 2000,
    });
  }

}
