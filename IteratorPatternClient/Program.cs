using System;
using System.Collections.Generic;
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

            Console.WriteLine("\n\n======================================================================================================\n\n");

            // Combine diner menu, pancake house menu and cafe menu into one menu list
            List<IMenu> menuList = new List<IMenu>
            {
                dinerMenu,
                pancakeMenu,
                cafeMenu
            };
            Waitress waitress2 = new Waitress(menuList);
            waitress2.PrintMenu2();

            Console.ReadKey();
        }
    }
}
