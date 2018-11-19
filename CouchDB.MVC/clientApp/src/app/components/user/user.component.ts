import { Component, OnInit } from '@angular/core';
import { IUser } from 'src/app/Interfaces/IUser';
import { UserService } from './user.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  users: IUser[] = [];
  displayedColumns = ['username', 'email', 'rol', 'actions'];
  constructor(private userService: UserService) { }

  ngOnInit() {
    this.getUsers();
  }

  getUsers(): void {
   this.userService.GetAllUsers().subscribe(
     (res: IUser[]) => {
      this.users = res;
     }, (error: any) => {
       console.log(error);
    });
  }

}
