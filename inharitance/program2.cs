using System;
using System.Collections.Generic;
using System.Text;

namespace inharitance
{
    class program2:Program1
    {
        public  void Test3()
        {
            Console.WriteLine("Raju");
        }
        static void Main()
        {
            program2 c = new program2();
            c.Test();
            c.Test2();
            c.Test3();
            Console.ReadLine();

        }
    }
}
