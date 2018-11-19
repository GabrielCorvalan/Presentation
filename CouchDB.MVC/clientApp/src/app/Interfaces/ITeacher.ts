import { IBase } from './IBase';
import { IAddress } from './IAddress';

export interface ITeacher extends IBase {
    names: string;
    surnames: string;
    teacherFile: number;
    birthdate: Date;
    dni: number;
    cuil: number;
    address: IAddress;
}