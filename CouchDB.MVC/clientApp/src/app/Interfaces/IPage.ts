import { IBase } from './IBase';

export interface IPage extends IBase {
    pageUrl: string;
    description: string;
    tittle: string;
}