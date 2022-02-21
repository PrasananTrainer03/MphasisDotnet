import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { Menu } from './menu';

@Injectable({
  providedIn: 'root'
})
export class MenuService {

  constructor(private _http: HttpClient) { }

  showMenu(rid : number): Observable<Menu[]> {
    return this._http.get<Menu[]>("http://localhost:8181/showMenu/"+rid)
      .pipe(
        tap(data =>
        console.log('All: ' + JSON.stringify(data)))
      );
  }

  searchByMenuId(mid : number): Observable<Menu> {
    return this._http.get<Menu>("http://localhost:8181/search/"+mid)
      .pipe(
        tap(data =>
        console.log('All: ' + JSON.stringify(data)))
      );
  }
}
