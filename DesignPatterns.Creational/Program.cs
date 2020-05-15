using System;

namespace DesignPatterns.Creational
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunFactoryMethod();
            RunAbstractFactory();

            Console.ReadLine();
        }

        public static void RunFactoryMethod() =>
            new FactoryMethod.App(OS.Windows).Run();

        public static void RunAbstractFactory() =>
            new AbstractFactory.App(OS.Mac).Run();
    }
}
