using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WinCheckbox : Checkbox
    {
        public override void Paint()
        {
            Console.WriteLine("Render a checkbox in Windows style.");
        }
    }
}
