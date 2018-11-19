import { Injectable } from '@angular/core';
import { DataService } from 'src/app/DataService';
import { HttpClient } from '@angular/common/http';
import { catchError, map } from 'rxjs/operators';
import { Observable } from 'rxjs/Observable';
import { IUser } from 'src/app/Interfaces/IUser';

@Injectable({
  providedIn: 'root'
})
export class LoginService extends DataService {

  constructor(private http: HttpClient) { super(); }

  checkLoging(userName: string, password: string): Observable<IUser> {
    return this.http.get(this._baseUrl + 'login/AuthLogin/' + userName + '/' + password ).pipe(
      map((res: boolean) => {
        return res;
      }),
      catchError(this.handleError), );
  }
}
