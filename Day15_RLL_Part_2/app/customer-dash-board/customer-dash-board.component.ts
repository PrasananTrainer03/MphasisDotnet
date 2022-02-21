import { Component, OnInit } from '@angular/core';
import { Customer } from '../customer';
import { CustomerService } from '../customer.service';

@Component({
  selector: 'app-customer-dash-board',
  templateUrl: './customer-dash-board.component.html',
  styleUrls: ['./customer-dash-board.component.css']
})
export class CustomerDashBoardComponent implements OnInit {

  cid : number;
  customer : Customer;
  constructor(private _customerService : CustomerService) { 
    // this.cid = parseInt(localStorage.getItem("custId"));
    // this._customerService.searchCustomer(this.cid).subscribe(x => {
    //   this.customer=x;
    // })
//    this.customer = this._customerService.searchCustomer(this.cid);
  }

  ngOnInit(): void {
  }

}
