using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer
{
    [DebuggerDisplay("model = {model} price = {price*3.6f}")]
    class Computer
    {

        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;

        public int TellMeThePrice()
        {
            return price;
        }
        public float TellMeThescreenSize()
        {
            return screenSize;
        }
        public void TurnOn()
        {
            isTurnOn = true;
        }
        public void TurnOff()
        {
            isTurnOn = false;
        }

        public void AddProcessor()
        {
            numberOfProcessors++;
        }

        public override string ToString()
        {
            return $"the price is: {price} the screen size is: {screenSize}, the model is: {model}" +
                $" the number of processors is {numberOfProcessors} is turn on? { isTurnOn}";
        }

    }
}
