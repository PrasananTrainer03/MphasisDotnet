import { Component, OnInit } from '@angular/core';
import { Vendor } from '../vendor';
import { VendorService } from '../vendor.service';

@Component({
  selector: 'app-vendor-show',
  templateUrl: './vendor-show.component.html',
  styleUrls: ['./vendor-show.component.css']
})
export class VendorShowComponent implements OnInit {

  vendors : Vendor[];
  constructor(private _vendorService :VendorService) {
    this._vendorService.showVendors().subscribe({
      next: rs =>{
        this.vendors = rs;
      }
    })
  }
  ngOnInit(): void {
  }

}
