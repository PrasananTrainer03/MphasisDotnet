import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit {

  constructor() { }
  hello() {​​​​
    alert("Welcome to Angular Programming events...");
    }
  topic() {​​​​
      alert("Angular session...");
    }
  month() {​​​​
      alert("December...");
  }
  ngOnInit(): void {
  }

}
