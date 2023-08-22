using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Model
{
    // Concrete command classes
    internal class LightOn : ICommand
    {
        private Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    
    }
}
