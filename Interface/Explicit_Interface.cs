using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interface
{
    interface i1
    {
        void show();
    }
    interface i2
    {
               void show(); 
    }
    public class MyClass : i1
    {
        public void show()
        {
            throw new NotImplementedException();
        }
    }
    internal class Explicit_Interface
    {

    }
}
