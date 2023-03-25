import {Inject, Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders, HttpParams} from '@angular/common/http';
import {Workspace} from '../models/workspace';
import {catchError} from 'rxjs/operators';
import {Observable, throwError} from 'rxjs';
import {HandleError, HttpErrorHandler} from './http-error-handler.service';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable()
export class WorkspaceService {
  workspaceUrl: string;
  private handleError: HandleError;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    httpErrorHandler: HttpErrorHandler) {
    this.handleError = httpErrorHandler.createHandleError('WorkspaceService');
    this.workspaceUrl = baseUrl + 'api/workspacedata';
  }

  getAllWorkspaces(): Observable<Workspace[]> {
    return this.http.get<Workspace[]>(this.workspaceUrl)
      .pipe(
        catchError(this.handleError('getAllWorkspaces', []))
      );
  }

  searchWorkspaces(term: string): Observable<Workspace[]>{
    term = term.trim();

    const options = term ?
      {params: new HttpParams().set('name', term) } : {};

    return this.http.get<Workspace[]>(this.workspaceUrl, options)
      .pipe(
        catchError(this.handleError<Workspace[]>('searchWorkspaces', []))
      )
  }

  addWorkspace(workspace: Workspace): Observable<Workspace> {
    return this.http.post<Workspace>(this.workspaceUrl, workspace, httpOptions)
      .pipe(
        catchError(this.handleError('addWorkspace', workspace))
      );
  }

  deleteWorkspace(id: string): Observable<unknown> {
    const url = `${this.workspaceUrl}/${id}`;
    return this.http.delete(url, httpOptions)
      .pipe(
        catchError(this.handleError('deleteWorkspace'))
      );
  }

  updateWorkspace(workspace: Workspace): Observable<Workspace> {
    return this.http.put<Workspace>(this.workspaceUrl, workspace, httpOptions)
      .pipe(
        catchError(this.handleError('updateWorkspace', workspace))
      );
  }
}
