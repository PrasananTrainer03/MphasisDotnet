import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { Vendor } from './vendor';

@Injectable({
  providedIn: 'root'
})
export class VendorService {

  constructor(private _http: HttpClient) { }

  showVendors(): Observable<Vendor []> {
    return this._http.get<Vendor[]>("http://localhost:8181/vendors")
      .pipe(
        tap(data =>
        console.log('All: ' + JSON.stringify(data)))
      );
  }
}
