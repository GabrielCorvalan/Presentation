import { IStudent } from './IStudent';
import { IBase } from './IBase';
import { ITeacher } from './ITeacher';
import { IRol } from './IRol';

export interface IUser extends IBase {
    userName: string;
    email: string;
    password: string;
    student?: IStudent;
    teacher?: ITeacher;
    rolId: number;
    rol: IRol;
}