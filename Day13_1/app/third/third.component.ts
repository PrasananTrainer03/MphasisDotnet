import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-third',
  templateUrl: './third.component.html',
  styleUrls: ['./third.component.css']
})
export class ThirdComponent implements OnInit {
  student : string ;
  company : string ; 

  constructor() { 
    this.student = "Aneena";
    this.company = "Hexaware";
  }

  ngOnInit(): void {
  }

}
