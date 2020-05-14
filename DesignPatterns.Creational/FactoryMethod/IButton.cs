using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public interface IButton
    {
        void Render();
        void OnClick();
    }
}
