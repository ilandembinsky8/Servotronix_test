using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static int factorial(int n)
        {
            if (n>1)
                return factorial(n-1)*n;
            return 1;
        }
        static void Main(string[] args)
        {
            int x = factorial(4);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
