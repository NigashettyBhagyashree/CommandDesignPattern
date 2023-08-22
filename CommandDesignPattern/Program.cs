using CommandDesignPattern.Model;

namespace CommandDesignPattern
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                // Create receiver objects
                Light livingRoomLight = new Light();
                TV livingRoomTV = new TV();

                // Create command instances
                ICommand lightOn = new LightOn(livingRoomLight);
                ICommand lightOff = new LightOff(livingRoomLight);
                ICommand tvOn = new TVOn(livingRoomTV);
                ICommand tvOff = new TVOff(livingRoomTV);

                // Create invoker
                RemoteControl remote = new RemoteControl();

                // Set commands for invoker
                remote.SetCommand(lightOn);

                // Press button to turn on the light
                remote.PressButton();

                // Change the command and press button to turn off the light
                remote.SetCommand(lightOff);
                remote.PressButton();

                // Change the command and press button to turn on the TV
                remote.SetCommand(tvOn);
                remote.PressButton();

                // Change the command and press button to turn off the TV
                remote.SetCommand(tvOff);
                remote.PressButton();
            }
        }
    }
