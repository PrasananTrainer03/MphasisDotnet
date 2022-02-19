import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowComponent implements OnInit {

  trainer : string;
  student : string;
  constructor() {
    this.trainer="Prasanna...";
    this.student="Mil Patel...";
   }

  ngOnInit(): void {
  }

}
