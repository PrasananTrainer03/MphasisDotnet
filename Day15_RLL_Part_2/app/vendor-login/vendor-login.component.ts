import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-vendor-login',
  templateUrl: './vendor-login.component.html',
  styleUrls: ['./vendor-login.component.css']
})
export class VendorLoginComponent implements OnInit {

  custId : number;
  userName : string;
  passCode : string;
  
  logMe() {
  //  alert(this.custId);
  //  localStorage.setItem('custId',this.custId.toString());
    if (this.passCode=="Mphasis" && this.userName=="Mphasis") {
      this._router.navigate(['/vendorDashBoard']);

    }
  }
  constructor(private _router : Router) { }

  ngOnInit(): void {
  }

}
