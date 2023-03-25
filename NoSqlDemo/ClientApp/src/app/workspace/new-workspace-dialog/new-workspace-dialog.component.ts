import {Component, Inject} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';
import {FormArray, FormBuilder, FormControl} from '@angular/forms';
import {Workspace} from '../models/workspace';

@Component({
  selector: 'new-workspace-dialog',
  templateUrl: 'new-workspace.dialog.html'
})
export class NewWorkspaceDialog {
  constructor(
    public dialogRef: MatDialogRef<NewWorkspaceDialog>,
    @Inject(MAT_DIALOG_DATA) public data: Workspace,
    private fb: FormBuilder
  ) {
  }

  workspaceForm = this.fb.group({
    name: [''],
    windows: this.fb.array([
    ])
  });

  get windows() {
    return this.workspaceForm.get('windows') as FormArray;
  }

  addWindow() {
    this.windows.push(this.fb.group({
      title: [''],
      positionX: [''],
      positionY: ['']
    }))
  }

  onCancel(): void {
    this.dialogRef.close();
  }
}
