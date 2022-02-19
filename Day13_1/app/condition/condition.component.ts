import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-condition',
  templateUrl: './condition.component.html',
  styleUrls: ['./condition.component.css']
})
export class ConditionComponent implements OnInit {
  cgpa : number;
  constructor() {
    this.cgpa = 6.5;
   }

  ngOnInit(): void {
  }

}
