
export class Student {
    id: string;
    firstName: string;
    lastName: string;
    birthdate: Date;
    dni: string;
    cuil: string;
    deleted: boolean;
    studentFile: string;

    constructor() {
        id = '';
        firstName = '';
        lastName = '';
        birthdate = new Date();
        dni = '';
        cuil = '';
        deleted = false;
        studentFile = '';
    }
// tslint:disable-next-line:eofline
}