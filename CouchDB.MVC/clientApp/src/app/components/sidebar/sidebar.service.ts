import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map, catchError } from 'rxjs/operators';
import { Observable } from 'rxjs/Observable';
import { DataService } from 'src/app/DataService';
import { IPage } from 'src/app/Interfaces/IPage';

@Injectable({
  providedIn: 'root'
})
export class SidebarService extends DataService {

  constructor(private http: HttpClient) { super(); }

  getAllPages(): Observable<IPage[]> {
    return this.http.get(this._baseUrl + 'Page').pipe(
      map( res => {
        return res;
      }),
      catchError(this.handleError), );
  }
}
