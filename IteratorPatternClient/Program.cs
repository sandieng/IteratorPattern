using System;
using IteratorPattern;
using IteratorPattern.ConcreteAggregate;

namespace IteratorPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DinerMenu dinerMenu = new DinerMenu();
            //  PancakeHouseMenu pancakeMenu = new PancakeHouseMenu();
            //  CafeMenu cafeMenu = new CafeMenu();
            IMenu dinerMenu = new DinerMenu();
            IMenu pancakeMenu = new PancakeHouseMenu();
            IMenu cafeMenu = new CafeMenu();
            Waitress waitress = new Waitress(dinerMenu, pancakeMenu, cafeMenu);
           
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
