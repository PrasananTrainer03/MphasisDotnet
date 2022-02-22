import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Employ } from '../employ';

@Component({
  selector: 'app-employ',
  templateUrl: './employ.component.html',
  styleUrls: ['./employ.component.css']
})
export class EmployComponent implements OnInit {

  employ : Employ;
  isValid : boolean;
  msg : string;
  show(employForm : NgForm) {
    if (employForm.invalid) {
  //    prompt("Hi","Bye")
      return;
    }    
    this.isValid=true;
    this.msg="Form Submitted Successfully...";
  }
  constructor() { 
    this.employ = new Employ();
    this.isValid=false;
  }

  ngOnInit(): void {
  }

}
