import {WindowModel} from './window.model';

export class GridWindow implements WindowModel {
  constructor(id: string,
              position: [number, number],
              title: string,
              columnHeaders: string[],
              rowHeaders: string[]) {
    this.id = id;
    this.position = position;
    this.title = title;
    this.columnHeaders = columnHeaders;
    this.rowHeaders = rowHeaders;
  }

  id: string;
  position: [number, number];
  title: string;
  columnHeaders: string[];
  rowHeaders: string[];
}
