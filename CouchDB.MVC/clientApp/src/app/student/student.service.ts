import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { map, catchError } from 'rxjs/operators';
import { Observable } from 'rxjs/Observable';
import { IStudent } from '../Interfaces/IStudent';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { DataService } from '../DataService';

@Injectable({
  providedIn: 'root'
})
export class StudentService extends DataService {
  public url: string;

  constructor(private http: HttpClient) {
    super();
    this.url = 'https://localhost:44321/api';
  }

  getStudents(): Observable<IStudent[]> {
    return this.http.get(this.url + '/student').pipe(
      map(res => {
        return res;
      }),
      catchError(this.handleError), );
  }

  getStudentById(id: string): Observable<IStudent> {
    return this.http.get(this.url + '/student/' + id).pipe(
      map((res: IStudent) => {
        return res;
      }),
      catchError(this.handleError), );
  }

  createStudent(student: IStudent): Observable<boolean> {
    const headers: HttpHeaders = new HttpHeaders().set('Content-Type', 'application/json');
    const result = JSON.stringify(student);
    return this.http.post(this.url + '/student', result, { headers: headers }).pipe(
      map(res => {
        return res;
      }),
      catchError(this.handleError), );
  }

  deleteStudent(id: string): Observable<boolean> {
    return this.http.delete(this.url + '/student/' + id).pipe(
      map((res: boolean) => {
        return res;
      }),
      catchError(this.handleError), );
  }
}
