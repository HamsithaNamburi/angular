using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcexample.Models;
namespace mvcexample.Repositories
{
    public class userrepository
    {
        public static List<user> ulist = new List<user>()
        {

            new user() { Name = "Rohith", country = "India", uname = "divya", pwd ="12345" }
        };
        public userrepository()
        {

        }
        public void Add(user item)
        {
           ulist .Add(item);//add user data to list
        }
        public user validate(string uname,string pwd)
        {
            foreach(var item in ulist)
            {
                if (item.uname==uname && item.pwd== pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
