using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class WindowsButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Windows Button Clicked");
        }

        public void Render()
        {
            Console.WriteLine("Rendering Windows Button");
        }
    }
}
