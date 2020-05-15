using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WinButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Render a button in Windows style.");
        }
    }
}
