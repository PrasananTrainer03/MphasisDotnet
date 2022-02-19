import { Component, OnInit } from '@angular/core';
import {​​​​​ Student }​​​​​ from '../student';
@Component({
  selector: 'app-student-dropdown',
  templateUrl: './student-dropdown.component.html',
  styleUrls: ['./student-dropdown.component.css']
})
export class StudentDropdownComponent implements OnInit {
  firstName : string;
  students = [
    new Student(1,'Sparsh','Manoj','Delhi',8),
    new Student(2,'Amrit','Beena','Bangl',9),
    new Student(3,'Manas','Aneena','Kochi',8.2),
    new Student(4,'Priyanka','Alv','Programmer',8.5),
    new Student(5,'Nivetha','Jane','Programmer',4),
    new Student(6,'Naina','Java','Programmer',4),
    new Student(7,'Jahnavi','Angular','Programmer',7),
    new Student(8,'Mustafeed','Sql','Developer',7),
    new Student(9,'Sundaram','Cordova','AppDeveloper',2),
  ]

  constructor() {
    this.firstName = "";
   }

  ngOnInit(): void {
  }

}
