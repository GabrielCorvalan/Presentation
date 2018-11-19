import { Component, OnInit } from '@angular/core';
import { LoginService } from './login.service';
import { IUser } from 'src/app/Interfaces/IUser';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  user: IUser;
  form: FormGroup;
  constructor(public loginService: LoginService,
              public fb: FormBuilder,
              public router: Router) {  }

  ngOnInit() {
    this.InitForm();
  }

  InitForm() {
    this.form = this.fb.group({
      userName: '',
      password: ''
    });
  }

  authenticate(): void {
    this.loginService.checkLoging(this.form.value.userName, this.form.value.password).subscribe(
      (res: IUser) => {
        this.user = res;
        if (this.user != null) {
          this.router.navigate(['/home']);
        } else {
          console.log('user or password incorrect');
        }
      },
      (error: any) => {
        console.log(error);
      });
  }

}
