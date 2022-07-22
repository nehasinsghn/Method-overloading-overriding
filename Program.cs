using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    // Method Overloading
    class A
    {
        public void show()
        {
            Console.WriteLine("This is Parameteless Method");
        }
        public int show(int a)
        {
            Console.WriteLine("This is Parameteries Method");
            return 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.show();
            obj.show(23);
            Console.ReadLine();
        }
    }
}
