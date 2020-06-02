using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    //generics
    public class GenType<T>
    {
        public void Method<A>(A input)
        {
            Console.WriteLine(input);
        }
    }
}
