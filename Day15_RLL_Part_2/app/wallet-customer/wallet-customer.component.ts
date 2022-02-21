import { Component, OnInit } from '@angular/core';
import { Wallet } from '../wallet';
import { WalletService } from '../wallet.service';

@Component({
  selector: 'app-wallet-customer',
  templateUrl: './wallet-customer.component.html',
  styleUrls: ['./wallet-customer.component.css']
})
export class WalletCustomerComponent implements OnInit {

  cid : number;
  wallet: Wallet[];
  constructor(private _walletService : WalletService) { 
    this.cid = parseInt(localStorage.getItem("custId"));
    this._walletService.showCustomerWallet(this.cid).subscribe(x => {
      this.wallet = x;
    });
  }
  ngOnInit(): void {
  }

}
