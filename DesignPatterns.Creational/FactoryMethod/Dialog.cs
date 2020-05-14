using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Dialog
    {
        public void Render()
        {
            IButton okButton = CreateButton();
            okButton.OnClick();
            okButton.Render();
        }

        public abstract IButton CreateButton();
    }
}
