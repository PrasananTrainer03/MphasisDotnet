import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { Restaurant } from './restaurant';
@Injectable({
  providedIn: 'root'
})
export class RestaurantService {

  constructor(private _http: HttpClient) { }

  showRestaurant(): Observable<Restaurant []> {
    return this._http.get<Restaurant []>("http://localhost:8181/showRestaurant")
      .pipe(
        tap(data =>
        console.log('All: ' + JSON.stringify(data)))
      );
  }
}
