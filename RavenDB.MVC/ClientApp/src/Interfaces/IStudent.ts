import { IBase } from "./IBase";

export interface IStudent extends IBase {
  name: string,
  career: string,
  years: number
};
