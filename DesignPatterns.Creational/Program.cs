using System;

namespace DesignPatterns.Creational
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFactoryMethod();
        }

        public static void RunFactoryMethod() =>
            new FactoryMethod.App(FactoryMethod.Os.Windows).Run();
    }
}
