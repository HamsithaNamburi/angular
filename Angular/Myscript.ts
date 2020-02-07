// console.log("Welcome to type Script");
// let mystring :string;//declaring the datatype
// let myNumber:number;
// let mystatus:boolean;
// mystring="TypeScript";
// myNumber=123;
// mystatus=true;
// console.log(mystring);
// console.log(myNumber);
// console.log(mystatus);
// let mydata:any;
// mydata="hello";
// console.log(mydata);
// mydata=12+123;
// console.log(mydata);
// let mystring:string;
// mystring="Welcome To Chennai";
// console.log(mystring.slice(0,3));
// let myNumber=100;
// console.log(myNumber.toString()+"myresult");
// let myArray:Array<string>
// let mynArray:Array<number>
// let myArrays:string[];
// let myArrayss:number[];
// myArrays=["Hello","TypeScript"];
// myArrayss=[2,4,6,7,8];
// console.log(myArrays[1]);
// console.log(myArrayss[4]);
// myArray=["Hello","TypeScript"];
//  mynArray=[2,4,6,7,8];
// for(var n=0;n<myArray.length;n++)
// {
// console.log(myArray[n]);
// }
// myArray.forEach(function(value){
//     console.log(value);
// })
// let mytuple:[number,string,string]
// mytuple=[1,"sdgtrdyht","gsudifr"];
// console.log(mytuple);
// let myvar:void;
// myvar=undefined;
// console.log(myvar);
// let myvar1:null;
// myvar1=null;
// console.log(myvar1);
// console.log(mytuple.pop());
// mytuple.push(23);
// console.log(mytuple);
// enum myenum{sunday=0,monday,tuesday,wed,thursday,}
// console.log(myenum.thursday);
// //Functions
// function myfunction(n1:number,n2:number):number{
//     return n1+n2;

// }
// console.log(myfunction(656,856));
// function myfun(n1:any,n2:any):any{
//     return n1+n2;

// }
// console.log(myfun("sfgdsgf","sdgfds"));
// function myAddfunc(n1:any,n2:any):number{
//     return n1+n2;

// }
// console.log(myfunction(656,856));
// function myfunc(n1:any,n2:any):number{
//     if(typeof(n1)=='string'&&typeof(n2)=='string'){
//         let x:number;
//         let y:number;
//         x=parseInt(n1);
//         y=parseInt(n2);
//         return (x+y);
//     }
//     return n1+n2;

// }
// console.log(myfunc("6","8"));
// function getName(firstname:string,lastname:string)
// {
//     if(lastname==undefined) return firstname;
//     return(firstname+" "+lastname);
// }
// console.log(getName("jhon",""))
// interface myInterface{
//     Name:string;
//     Title:string;
// }
// function Ifunction(mydata:myInterface):string{
//     return(mydata.Name+" "+mydata.Title);

// }
// let dat={Name:"David",Title:"Associate"}
// console.log(Ifunction(dat));
interface Iuser{
    id:number;
    Name:string;
    Email:string;
    Age:number;
    register():void;
    getAge(id:number):number;

}
class user implements Iuser{
     id:number;
    Name:string;
    Email:string;
    Age:number;
    
    constructor(id:number,name:string,email:string,age:number)
    {
        this.id=id;
        this.Name=name;
        this.Email=email;
        this.Age=age;
        console.log("user created");
    }
    register()
{
console.log(this.Name+"Successfully registerd");
}
getAge(id:number):number{
    if(this.id==id)
    return this.Age;
    else return 0;

}
}

 let firstuser=new user(1,"Jane","Jane@cts",34);
 firstuser.register();
 console.log(firstuser.id+" "+firstuser.Name+" "+firstuser.Email+" "+firstuser.Age);
 console.log(firstuser.getAge(1));
//  class AdminUser extends user{
//      Type:string;
//       constructor (id:number,name:string,email:string,age:number,Type:string){
//       super(id,name,email,age);
//       this.Type=Type;
//      }
//      displayAdmin(){
//          console.log("You are"+this.Type);
//          console.log(this.id+" "+this.Name+" "+this.Email+" "+this.Age+""+this.Type);
//      }
     
//  }
//   let Cuser=new AdminUser(2,"james","james@cts",45,"Associate");
//   Cuser.register();
//   Cuser.displayAdmin();
  


































