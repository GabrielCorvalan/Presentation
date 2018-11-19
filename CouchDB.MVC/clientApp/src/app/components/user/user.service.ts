import { Injectable } from '@angular/core';
import { DataService } from 'src/app/DataService';
import { HttpClient } from '@angular/common/http';
import { map, catchError } from 'rxjs/operators';
import { Observable } from 'rxjs/Observable';
import { IUser } from 'src/app/Interfaces/IUser';


@Injectable({
  providedIn: 'root'
})
export class UserService extends DataService {

  constructor(private http: HttpClient) { super(); }

  GetAllUsers(): Observable<IUser[]> {
    return this.http.get(this._baseUrl + 'user').pipe(
      map(res => {
        return res;
      }),
      catchError(this.handleError), );
  }
}
