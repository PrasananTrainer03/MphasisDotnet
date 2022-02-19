import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map';
import { Customer } from './customer';
import { Orders } from './orders';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http : Http) { }

  validateCustomer(user : string, pwd : string) : Observable<string> {
    return this.
    http.get("http://localhost:8080/CmsNewProject/webapi/customer/"+user+"/"+pwd).
    map((res : Response) => res.text());
  }
  findByCustomerName(user : string) : Observable<Customer> {
    return this.
    http.get("http://localhost:8080/CmsNew/webapi/customer/name/"+user).
    map((res : Response) => res.json());
  }
  orderHistory(custId : number) : Observable<Orders[]> {
    return this.
    http.get("http://localhost:8080/CmsNewProject/webapi/orders/customer/"+custId).
    map((res : Response) => res.json());
  }
  pendingHistory(custId : number) : Observable<Orders[]> {
    return this.
    http.get("http://localhost:8080/CmsNewProject/webapi/orders/customerpending/"+custId).
    map((res : Response) => res.json());
  }
  placeOrder(orders : Orders) : Observable<string> {
    return this.http.post("http://localhost:8080/CmsNew/webapi/orders/placeorder/",orders).
    map((res : Response) => res.text());
  }
  cancelOrder(ordId : number, cusId : number, status : String,) : Observable<string> {
    return this.http.post("http://localhost:8080/MLP173/api/orderdetail/cancelOrder/"+ordId + "/" +cusId+ "/" +status,null).
    map((res : Response) => res.text());
  }
}
