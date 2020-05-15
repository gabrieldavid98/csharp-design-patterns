using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MacButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Render a button in macOS style.");
        }
    }
}
