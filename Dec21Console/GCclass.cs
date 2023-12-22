using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21Console
{
    internal class GCclass
    {
        public class ParentClass { 
        public ParentClass() {
                Console.WriteLine("I am Parent Constructor");
            }
            ~ParentClass()
            {
                Console.WriteLine("I am Parent Destructor");
            }
        }
        public class ChildClass:ParentClass {
        public ChildClass()
            {
                Console.WriteLine("I am Clild Constructor");
            }
            ~ChildClass()
            {
                Console.WriteLine("I am Child Destructor");
            }
        }
    }
}
