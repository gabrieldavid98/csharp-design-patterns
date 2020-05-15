using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Gui
    {
        private IGUIFactory _factory;
        private Button _button;
        private Checkbox _checkbox;

        public Gui(IGUIFactory factory) =>
            _factory = factory;

        public void CreateUI()
        {
            _button = _factory.CreateButton();
            _checkbox = _factory.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}
