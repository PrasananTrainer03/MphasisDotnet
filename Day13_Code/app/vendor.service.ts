import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map';
import { Vendor } from './vendor';
import { Orders } from './orders';
@Injectable({
  providedIn: 'root'
})
export class VendorService {

  constructor(private http : Http) { }

  validateVendor(user : string, pwd : string) : Observable<string> {
    return this.
    http.get("http://localhost:8080/CmsNewProject/webapi/vendor/"+user+"/"+pwd).
    map((res : Response) => res.text());
  }
  findByVendorName(user : string) : Observable<Vendor> {
    return this.
    http.get("http://localhost:8080/CmsNewProject/webapi/vendor/"+user).
    map((res : Response) => res.json());
  }
  orderHistory(vendId : number) : Observable<Orders[]> {
    return this.
    http.get("http://localhost:8080/CmsNewProject/webapi/orders/vendor/"+vendId).
    map((res : Response) => res.json());
}
pendingHistory(vendId : number) : Observable<Orders[]> {
  return this.
  http.get("http://localhost:8080/CmsNewProject/webapi/orders/vendorpending/"+vendId).
  map((res : Response) => res.json());
}
  searchVendor(venName : number) : Observable<Vendor>{
    return this.
    http.get("http://localhost:8080/MLP173/api/vendor/VendorName/"+venName).
    map((res : Response)=> res.json());
}
showVendor() : Observable<Vendor[]>{
  return this.
  http.get("http://localhost:8080/CmsNewProject/webapi/vendor/").
  map((res : Response)=> res.json());
}
acceptOrReject(ordId : number, vendId : number, status : String) : Observable<string> {
  return this.http.post("http://localhost:8080/MLP173/api/orderdetail/acceptOrRejectOrder/"+ordId + "/" + vendId + "/" +status,null).
  map((res : Response) => res.text());
}

}