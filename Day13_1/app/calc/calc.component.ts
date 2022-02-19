import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent implements OnInit {
  firstNo : number;
  secondNo : number;
  result : number;
  constructor() {
    this.firstNo = 0;
    this.secondNo = 0;
    this.result = 0;
   }
  sum() {​​​​
    this.result = this.firstNo + this.secondNo;
  }​​​​
  sub() {​​​​
    this.result = this.firstNo - this.secondNo;
  }​​​​
  mul() {​​​​
    this.result = this.firstNo * this.secondNo;
  }​​​​
  div() {​​​​
    this.result = this.firstNo / this.secondNo;
  }​​​​
  ngOnInit(): void {
  }

}


