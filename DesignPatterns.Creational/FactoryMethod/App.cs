using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{

    public enum Os
    {
        Windows,
        Web
    }

    public class App
    {
        private Dialog _dialog;

        public App(Os os)
        {
            if (os == Os.Windows)
            {
                _dialog = new WindowsDialog();
            }

            if (os == Os.Web)
            {
                _dialog = new HtmlDialog();
            }
        }

        public void Run()
        {
            _dialog.Render();
        }
    }
}
