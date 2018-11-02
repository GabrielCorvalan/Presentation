import {throwError as observableThrowError,  Observable } from 'rxjs';
import { Injectable } from '@angular/core';
// import { Http, Response, Headers }             from "@angular/http";
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()
export class DataService {

    _baseUrl = '';

    constructor() {
    }

    public handleError(error: any): Observable<any> {
        if (error.status === 401 || error.status === 403) {
            return observableThrowError(error);
        }

        const applicationError: any = error.headers.get('Application-Error');
        const serverError: any = error;
        let modelStateErrors = '';

        if (serverError.status === 400 && serverError.error) {
            if (typeof (serverError.error) === 'string') {
                modelStateErrors = serverError.error;
            } else {
                modelStateErrors = serverError.error[Object.keys(serverError.error)[0]];
            }
        } else {
            modelStateErrors = error.message + '\n';
        }

        return observableThrowError(applicationError || modelStateErrors || 'Server error');
    }
}
