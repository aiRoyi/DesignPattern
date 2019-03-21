using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light= new Light();
            LightOnCommand lightOnCmd = new LightOnCommand(light);
            remote.setCommand(lightOnCmd);
            remote.buttonWasPressed();
            Console.ReadLine();
        }
    }
}
