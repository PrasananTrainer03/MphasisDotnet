import { Component, OnInit } from '@angular/core';
import { Customer } from '../customer';
import { CustomerService } from '../customer.service';

@Component({
  selector: 'app-customer-show',
  templateUrl: './customer-show.component.html',
  styleUrls: ['./customer-show.component.css']
})
export class CustomerShowComponent implements OnInit {

  customers : Customer[];
  constructor(private _customerService :CustomerService) {
    this._customerService.showCustomer().subscribe({
      next: rs =>{
        this.customers = rs;
      }
    })
   }

  ngOnInit(): void {
  }

}
