import { Component, OnInit } from '@angular/core';
import { IStudent } from '../../Interfaces/IStudent';
import { StudentService } from './student.service';
import { map } from 'rxjs/operators';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {
  students: IStudent[] = [];
  displayedColumns = ['firtsName', 'lastName', 'DNI', 'studentFile', 'actions'];
  constructor(private studentService: StudentService,
              public snackBar: MatSnackBar) {
  }
  // Cuando inicia el component
  ngOnInit(): void {
      this.getAllStudents();
  }
  // Cargo el formulario
  getAllStudents(): void {
    this.studentService.getStudents()
      .subscribe((res: IStudent[]) => {
          this.students = res;
          console.log(res);
      }, (error: any): void => {
        console.log(error);
      });
  }
  deleteStudent(id: string): void {
    this.studentService.deleteStudent(id).subscribe((res: boolean) => {
      if (res) {
        this.openSnackBar('Operacion exitosa', 'Success');
        this.getAllStudents();
        // this.students.reduce(o => o._id == id,);
      } else {
        this.openSnackBar('Error en la operacion', 'Error');
      }
    }, (error: any): void => {
      console.log(error);
    });
  }

  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
      duration: 2000,
    });
  }
}
