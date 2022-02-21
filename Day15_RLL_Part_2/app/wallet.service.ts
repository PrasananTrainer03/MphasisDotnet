import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Wallet } from './wallet';
import { catchError, tap, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class WalletService {

  constructor(private _http: HttpClient) { }

  showCustomerWallet(cid : number): Observable<Wallet []> {
    return this._http.get<Wallet[]>("http://localhost:8181/showAllWallets/"+cid)
      .pipe(
        tap(data =>
        console.log('All: ' + JSON.stringify(data)))
      );
  }
  searchByWalletId(wid : number): Observable<Wallet> {
    return this._http.get<Wallet>("http://localhost:8181/searchByWalletId/"+wid)
      .pipe(
        tap(data =>
        console.log('All: ' + JSON.stringify(data)))
      );
  }
}
