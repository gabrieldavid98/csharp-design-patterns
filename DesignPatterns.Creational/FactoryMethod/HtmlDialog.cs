using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class HtmlDialog : Dialog
    {
        public override IButton CreateButton() =>
            new HtmlButton();
    }
}
