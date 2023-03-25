import {WindowModel} from './window.model';
import {ChartType} from './chartType';

export class ChartWindow implements WindowModel {
  constructor(id: string,
              position: [number, number],
              title: string,
              chartType: ChartType) {
    this.id = id;
    this.position = position;
    this.title = title;
    this.chartType = chartType;
  }

  id: string;
  position: [number, number];
  title: string;

  chartType: ChartType;

}
