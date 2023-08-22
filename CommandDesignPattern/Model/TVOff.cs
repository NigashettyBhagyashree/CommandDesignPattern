using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Model
{
    // Concrete command classes
    internal class TVOff : ICommand
    {
        private TV tv;

        public TVOff(TV tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.TurnOff();
        }

    }
}
