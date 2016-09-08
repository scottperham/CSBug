using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string ret = true ? null : new ClassWithImplicitOperator();
            Console.WriteLine(ret);
            Console.ReadLine();
        }
    }

    public class ClassWithImplicitOperator
    {
        public static implicit operator string (ClassWithImplicitOperator other)
        {
            Console.WriteLine("Implicitly casting...");
            return "";
        }
    }
}
