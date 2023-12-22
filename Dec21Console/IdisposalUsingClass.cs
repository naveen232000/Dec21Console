using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21Console
{
    public class IdisposalUsingClass:IDisposable
    {
      
            private bool _disposed=false;
            public void welcomeMsg()
            {
                Console.WriteLine("Welcome");
            }
            ~IdisposalUsingClass()
            {
                Console.WriteLine("From destructor class");
                Dispose(false);
            }
            public void Dispose()
            {
                Dispose(true);
              //  GC.SuppressFinalize(this);
            }
            public void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                    //obj = null;

                    }
                    _disposed = true;
                }
            }
            static void Main(string[] args)
            {
                using (IdisposalUsingClass c1 = new IdisposalUsingClass())
                {
                    c1.Dispose();

                }
                Console.ReadLine();

            }


        }
    }

