import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

userName : string;
passCode : string;

isValid : boolean;
login(loginForm : NgForm) {
  if (loginForm.invalid) {
    return;
  }
  this.isValid=true;
  if (this.userName=="Mphasis" && this.passCode=="Mphasis") {
    alert("Correct")
  } else {
    alert("invalid");
  }
}
  constructor() { 
    this.isValid=false;
  }

  ngOnInit(): void {
  }

}
