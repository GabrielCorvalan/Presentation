import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-plan-maters',
  templateUrl: './plan-maters.component.html',
  styleUrls: ['./plan-maters.component.css']
})
export class PlanMatersComponent implements OnInit {
  mockMaterias: any = [{
    anio: '1',
    cuatrimestres: '1/4',
    materia: 'Programacion I'
  },
  {
    anio: '1',
    cuatrimestres: '1/4',
    materia: 'Programacion II'
  },
  {
    anio: '1',
    cuatrimestres: '1/4',
    materia: 'Programacion III'
  },
  {
    anio: '1',
    cuatrimestres: '1/4',
    materia: 'Laboratorio I'
  },
  {
    anio: '1',
    cuatrimestres: '1/4',
    materia: 'Laboratorio II'
  },
  {
    anio: '1',
    cuatrimestres: '1/4',
    materia: 'Legislacion'
  },
  {
    anio: '1',
    cuatrimestres: '1/4',
    materia: 'Metodologia de sistemas'
  }
];
  constructor() { }

  ngOnInit() {
  }

}
