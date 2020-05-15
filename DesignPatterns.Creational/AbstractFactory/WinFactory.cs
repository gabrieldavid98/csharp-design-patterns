using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WinFactory : IGUIFactory
    {
        public Button CreateButton() => new WinButton();

        public Checkbox CreateCheckbox() => new WinCheckbox();
    }
}
