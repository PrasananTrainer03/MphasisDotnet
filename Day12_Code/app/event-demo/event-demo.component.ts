import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-event-demo',
  templateUrl: './event-demo.component.html',
  styleUrls: ['./event-demo.component.css']
})
export class EventDemoComponent implements OnInit {

  constructor() { }

  city() {
    alert("City is from Hyderabad...")
  }
  topic() {
    alert("Topic is Angular 10...")
  }

  hello() {
    alert("Welcome to Angular Events...")
  }
  ngOnInit(): void {
  }

}
