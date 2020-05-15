using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class App
    {

        private IGUIFactory _guiFactory;

        public App(OS os)
        {
            switch (os)
            {
                case OS.Windows:
                    _guiFactory = new WinFactory();
                    break;
                case OS.Mac:
                    _guiFactory = new MacFactory();
                    break;
                default:
                    throw new Exception("The OS is not supported!");
            }
        }

        public void Run()
        {
            var gui = new Gui(_guiFactory);
            gui.CreateUI();
            gui.Paint();
        }
    }
}
