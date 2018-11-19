import { IAddress } from './IAddress';

export interface IStudent {
  id: number;
  names: string;
  surnames: string;
  studentFile: number;
  birthdate: Date;
  dni: number;
  cuil: number;
  address: IAddress;
  deleted: boolean;
}
