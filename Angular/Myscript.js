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
var user = /** @class */ (function () {
    function user(id, name, email, age) {
        this.id = id;
        this.Name = name;
        this.Email = email;
        this.Age = age;
        console.log("user created");
    }
    user.prototype.register = function () {
        console.log(this.Name + "Successfully registerd");
    };
    user.prototype.getAge = function (id) {
        if (this.id == id)
            return this.Age;
        else
            return 0;
    };
    return user;
}());
var firstuser = new user(1, "Jane", "Jane@cts", 34);
firstuser.register();
console.log(firstuser.id + " " + firstuser.Name + " " + firstuser.Email + " " + firstuser.Age);
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
