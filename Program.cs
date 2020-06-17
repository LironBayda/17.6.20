using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp1 = new Computer();
            comp1.price = 9000;
            comp1.model = "AA2";
            comp1.screenSize = 3.4f;
            comp1.numberOfProcessors = 1;
            comp1.isTurnOn = false;

            comp1.TurnOff();
            comp1.TurnOn();
            comp1.TellMeThePrice();
            comp1.TellMeThescreenSize();
            comp1.AddProcessor();


            Computer comp2 = new Computer();
            comp2.price = 3000;
            comp2.model = "AABB2";
            comp2.screenSize = 10.4f;
            comp2.numberOfProcessors = 4;
            comp2.isTurnOn = true;

            comp2.TurnOff();
            comp2.TurnOn();
            comp2.TellMeThePrice();
            comp2.TellMeThescreenSize();
            comp2.AddProcessor();

            Computer comp3 = new Computer();
            comp3.price = 19000;
            comp3.model = "AACC2";
            comp3.screenSize = 16.4f;
            comp3.numberOfProcessors = 2;
            comp3.isTurnOn = false;

            comp3.TurnOff();
            comp3.TurnOn();
            comp3.TellMeThePrice();
            comp3.TellMeThescreenSize();
            comp3.AddProcessor();

            Console.WriteLine(comp1.ToString());
            Console.ReadLine();
        }
    }
}
