using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_5_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Ginger", Gender.Male);


            //test
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.CheckEnergy();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.CheckEnergy();
            c1.Sleep();
            c1.Sleep();



            Console.ReadKey();
        }
    }
}
