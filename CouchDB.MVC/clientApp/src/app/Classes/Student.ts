
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
        this.id = '';
        this.firstName = '';
        this.lastName = '';
        this.birthdate = new Date();
        this.dni = '';
        this.cuil = '';
        this.deleted = false;
        this.studentFile = '';
    }
// tslint:disable-next-line:eofline
}