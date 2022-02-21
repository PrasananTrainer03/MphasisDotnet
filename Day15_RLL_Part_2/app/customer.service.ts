import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { Customer } from './customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private _http: HttpClient) { }

  showCustomer(): Observable<Customer []> {
    return this._http.get<Customer[]>("http://localhost:8181/customer")
      .pipe(
        tap(data =>
        console.log('All: ' + JSON.stringify(data)))
      );
  }
  searchCustomer(cid : number): Observable<Customer> {
    return this._http.get<Customer>("http://localhost:8181/customer/"+cid)
      .pipe(
        tap(data =>
        console.log('All: ' + JSON.stringify(data)))
      );
  }
}
