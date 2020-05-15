using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{

    public class App
    {
        private Dialog _dialog;

        public App(OS os)
        {
            if (os == OS.Windows)
            {
                _dialog = new WindowsDialog();
            }

            if (os == OS.Web)
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
