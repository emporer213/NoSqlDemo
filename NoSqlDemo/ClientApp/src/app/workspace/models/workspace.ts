import {WindowModel} from './window.model';

export interface Workspace {
  id: string;
  name: string;
  windows: WindowModel[];
}
