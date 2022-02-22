import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-employ-reactive',
  templateUrl: './employ-reactive.component.html',
  styleUrls: ['./employ-reactive.component.css']
})
export class EmployReactiveComponent implements OnInit {

  isValid : boolean;
  msg : string;
  employForm = new FormGroup({
    empno : new FormControl('',Validators.required),
    name : new FormControl('',Validators.required),
    dept : new FormControl('',Validators.required),
    desig : new FormControl('',Validators.required),
    basic : new FormControl('',Validators.required)
  });
  show() {
    if (this.employForm.invalid) {
      return;
    }
    this.isValid=true;
    this.msg="Form Submitted"
  //  alert("Submitted...");
  }
  constructor() { 
    this.isValid=false;
  }

  ngOnInit(): void {
  }

}
