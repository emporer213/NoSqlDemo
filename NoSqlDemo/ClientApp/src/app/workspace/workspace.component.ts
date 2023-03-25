import {Component, OnInit} from '@angular/core';
import {Workspace} from './models/workspace';
import {MatDialog} from '@angular/material/dialog';
import {WorkspaceService} from './services/workspace.service';
import {NewWorkspaceDialog} from './new-workspace-dialog/new-workspace-dialog.component';
import {WindowModel} from './models/window.model';
@Component({
  selector: 'app-workspace-component',
  templateUrl: './workspace.component.html',
  providers: [WorkspaceService]
})
export class WorkspaceComponent implements OnInit {
  public workspaces: Workspace[] = [];
  columnsToDisplay = ['id', 'name', 'windows'];

  constructor(
    public dialog: MatDialog,
    private workspaceService: WorkspaceService) {}

  onCreate(): void {
    const dialogRef = this.dialog.open(NewWorkspaceDialog, {
      data: {id: crypto.randomUUID(), name: null, windows: null},
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.saveNewWorkspace(result)
    })
  }

  saveNewWorkspace(result: any) : void {
    let {name, windows} : {name: string; windows: WindowModel[]} = result;
    name = name.trim();
    if (!name) {
      return;
    }

    const newWorkspace: Workspace = { name, windows } as Workspace;
    this.workspaceService
      .addWorkspace(newWorkspace)
      .subscribe(workspace => this.workspaces.push(workspace));
  }

  ngOnInit(): void {
    this.getWorkspaces();
  }

  getWorkspaces(): void {
    this.workspaceService.getAllWorkspaces()
      .subscribe(workspaces => (this.workspaces = workspaces));
  }
}

