using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Model
{
    // Invoker class
    internal class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
    }
}
