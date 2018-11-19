import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map, catchError } from 'rxjs/operators';
import { Observable } from 'rxjs/Observable';
import { IStudent } from '../../Interfaces/IStudent';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { DataService } from '../../DataService';

@Injectable({
  providedIn: 'root'
})
export class StudentService extends DataService {

  constructor(private http: HttpClient) {
    super();
  }

  getStudents(): Observable<IStudent[]> {
    return this.http.get(this._baseUrl + '/student').pipe(
      map(res => {
        return res;
      }),
      catchError(this.handleError), );
  }

  getStudentById(id: string): Observable<IStudent> {
    return this.http.get(this._baseUrl + '/student/' + id).pipe(
      map((res: IStudent) => {
        return res;
      }),
      catchError(this.handleError), );
  }

  createStudent(student: IStudent): Observable<boolean> {
    const headers: HttpHeaders = new HttpHeaders().set('Content-Type', 'application/json');
    const result = JSON.stringify(student);
    return this.http.post(this._baseUrl + '/student', result, { headers: headers }).pipe(
      map(res => {
        return res;
      }),
      catchError(this.handleError), );
  }

  deleteStudent(id: string): Observable<boolean> {
    return this.http.delete(this._baseUrl + '/student/' + id).pipe(
      map((res: boolean) => {
        return res;
      }),
      catchError(this.handleError), );
  }
}
