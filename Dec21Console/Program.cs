using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dec21Console.GCclass;

namespace Dec21Console
{
    internal class Program
    {
        int id;
        string name, email, phoneNo;
        public Program() {
            Console.WriteLine("Constructor with no parameter");
        }
        public Program (int id, string name):this()
        {
            Console.WriteLine("2 parameter Constructor");
            this.id = id;
            this.name = name;
            Console.WriteLine($"id : {this.id}\nName : {this.name}");
        }
        public Program(int id, string name,string email,string phoneNo) : this(id,name)
        {
            Console.WriteLine("4 parameter Constructor");
            this.email = email;
            this.phoneNo = phoneNo;
            Console.WriteLine($"Email : {this.email}\nPhoneNo : {this.phoneNo}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Constructor with this Keyword\n");
            Program cust = new Program(1,"Naveen","N@gmail.com", "3265984512");
            Console.WriteLine("\nConstructor without this Keyword\n");
            ConstructWithoutThis conWotThis = new ConstructWithoutThis();
            ConstructWithoutThis conWotThis2 = new ConstructWithoutThis(1, "Naveen");
            ConstructWithoutThis conWotThis3=new ConstructWithoutThis(1, "Naveen", "N@gmail.com", "3265984512");

            Console.WriteLine("GC class GC.Collect()");
            ChildClass gCclass = new ChildClass();
            gCclass = null;
            //GC.Collect();
           
            
            Console.ReadLine();
        }
    }
}
