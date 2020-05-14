using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class WindowsDialog : Dialog
    {
        public override IButton CreateButton() =>
            new WindowsButton();
    }
}
