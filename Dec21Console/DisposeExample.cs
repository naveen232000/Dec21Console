using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21Console
{
    internal class DisposeExample
    {
        public class MyResource : IDisposable
        {
       
            private bool disposed = false;
            public MyResource()
            {
                Console.WriteLine("hiii");
            }
            public void Dispose()
            {
                Dispose(true);
              // GC.SuppressFinalize(this);
            }
            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {       
                    if (disposing)
                    {
                        Dispose(false);
                    }
                 
                    disposed = true;
                }
            }
     
      
            ~MyResource()
            {
                Console.WriteLine("dfbnmnm");
                Dispose(disposing: false);
                
            }
        }
        public static void Main()
        {
            MyResource mr= new MyResource();
            mr.Dispose();
            mr = null;
           
            Console.ReadLine();
        }
    }
}
