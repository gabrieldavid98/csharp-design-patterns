using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class HtmlButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Html Button Clicked");
        }

        public void Render()
        {
            Console.WriteLine("Rendering Html Button");
        }
    }
}
