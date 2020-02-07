import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',// or templet:'app.component.html'
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Demoangular';
  num:number=10;
  isdisabled:boolean=false;
  imagepath:string='assets/image/Jerry_Mouse.png';
  name:string="Jerry";
  fname:string="Tom";
  mystyle:string="boldclass italicclass"
  mystyle1:string="boldclass italicclass"
  getname():string{
    this.fname=this.fname.toUpperCase();
    return this.fname+"&"+this.name;
  }

}
