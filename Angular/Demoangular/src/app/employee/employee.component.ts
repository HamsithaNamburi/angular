import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'My-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent  {

  fname:string="jhon";
  lname:string="Z";
  Email:string="jhon@gmail.com";
  age:number=30;
  getStyle(){
    let styles={"font-style":"italic" ,"color":"brown"}
 return styles;
  }
  onclick(){
    console.log("you clicked");
  }
}
