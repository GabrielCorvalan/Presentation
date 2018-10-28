import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IStudent } from '../../Interfaces/IStudent';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public students: IStudent[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<IStudent[]>("http://localhost:53688/" + 'api/student').subscribe(result => {
      this.students = result;
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
