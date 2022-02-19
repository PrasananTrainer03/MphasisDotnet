import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FirstComponent } from './first/first.component';
import { SecondComponent } from './second/second.component';
import { ThirdComponent } from './third/third.component';
import { EventComponent } from './event/event.component';
import { TwowayComponent } from './twoway/twoway.component';
import { CalcComponent } from './calc/calc.component';
import { ConditionComponent } from './condition/condition.component';
import { EmployComponent } from './employ/employ.component';
import { StudentComponent } from './student/student.component';
import { EmployDropdownComponent } from './employ-dropdown/employ-dropdown.component';
import { StudentDropdownComponent } from './student-dropdown/student-dropdown.component';
import { MenuComponent } from './menu/menu.component';

// const appRoutes : Routes = [
//   {path:'first',component:FirstComponent},
//   {path:'second',component:SecondComponent},
//   {path:'third',component:ThirdComponent},
//   {path:'employ',component:EmployComponent},
//   {path:'employDropDown',component:EmployDropdownComponent},
//   {path:'student',component:StudentComponent},
//   {path:'menu',component:MenuComponent},
//   {path:'',component:MenuComponent}
// ]
// const appRoutes : Routes = [
//   {path:'first',component:FirstComponent},
//   {path:'second',component:SecondComponent},
//   {path:'third',component:ThirdComponent},
//   {path:'event',component:EventComponent},
//   {path:'calc',component:CalcComponent},
//   {path:'twoway',component:TwowayComponent},
//   {path:'condition',component:ConditionComponent},
//   {path:'employ',component:EmployComponent},
//   {path:'student',component:StudentComponent},
//   {path:'menu',component:MenuComponent},
//   {path:'',component:MenuComponent}
// ]
const appRoutes : Routes = [
   {path:'',component:MenuComponent},
  {path:'menu',component:MenuComponent,
  children : [
    {path:'first',component:FirstComponent,outlet:'data'},
  {path:'second',component:SecondComponent,outlet:'data'},
  {path:'third',component:ThirdComponent,outlet:'data'},
  {path:'event',component:EventComponent,outlet:'data'},
  {path:'calc',component:CalcComponent,outlet:'data'},
  {path:'twoway',component:TwowayComponent,outlet:'data'},
  {path:'condition',component:ConditionComponent,outlet:'data'},
  {path:'employ',component:EmployComponent,outlet:'data'},
  {path:'student',component:StudentComponent,outlet:'data'},

  ]
}
]
@NgModule({
  declarations: [
    AppComponent,
    FirstComponent,
    SecondComponent,
    ThirdComponent,
    EventComponent,
    TwowayComponent,
    CalcComponent,
    ConditionComponent,
    EmployComponent,
    StudentComponent,
    EmployDropdownComponent,
    StudentDropdownComponent,
    MenuComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
