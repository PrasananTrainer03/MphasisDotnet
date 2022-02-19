import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-butt-demo',
  templateUrl: './butt-demo.component.html',
  styleUrls: ['./butt-demo.component.css']
})
export class ButtDemoComponent implements OnInit {

  test() {
    alert("Test Method...Thank You...");
  }
  greeting() {
    alert("Greetings...Angular Coding...");
  }
  hello() {
    alert("Welcome to Angular Programming...");
  }
  constructor() { }

  ngOnInit(): void {
  }

}
