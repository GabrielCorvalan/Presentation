import { ICity } from './ICity';

export interface IAddress {
    city: ICity;
    houseNumber: number;
    zipCode: number;
    streets: string;
    otherInfo: string;
}