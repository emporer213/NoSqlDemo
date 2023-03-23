import {Component} from '@angular/core';
import {Workspace} from './models/workspace';

@Component({
  selector: 'app-workspace-component',
  templateUrl: './workspace.component.html'
})
export class WorkspaceComponent {
  public workspaces: Workspace[];
}
