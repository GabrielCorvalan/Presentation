import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mateers-create-or-update',
  templateUrl: './mateers-create-or-update.component.html',
  styleUrls: ['./mateers-create-or-update.component.css']
})
export class MateersCreateOrUpdateComponent implements OnInit {

  careers: any = ['Tecnico Superior en Programacion', 'Administracion'];
  constructor() { }

  ngOnInit() {
  }

}
