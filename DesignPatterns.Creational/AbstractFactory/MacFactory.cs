using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MacFactory : IGUIFactory
    {
        public Button CreateButton() => new MacButton();

        public Checkbox CreateCheckbox() => new MacCheckbox();
    }
}
