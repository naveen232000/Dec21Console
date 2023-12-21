using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21Console
{
    internal class ConstructWithoutThis
    {
        int id;
        string name, email, phoneNo;

        public ConstructWithoutThis() {
            Console.WriteLine("No parameter Constructor");
        }
        public ConstructWithoutThis(int id,string name)
        {
            Console.WriteLine("2 parameter Constructor");
            this.id = id;
            this.name = name;
            Console.WriteLine($"id : {this.id}\nName : {this.name}");
        }
        public ConstructWithoutThis(int id, string name, string email, string phoneNo) 
        {
            Console.WriteLine("4 parameter Constructor");
            this.id = id;
            this.name = name;
            this.email = email;
            this.phoneNo = phoneNo;
            Console.WriteLine($"id : {this.id}\nName : {this.name}\nEmail : {this.email}\nPhoneNo : {this.phoneNo}");

        }
    }
}
