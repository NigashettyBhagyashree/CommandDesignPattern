using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Model
{
    // Receiver classes
    internal class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is OFF");
        }
    }
}
