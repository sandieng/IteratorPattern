using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Waitress
    {
        //private readonly DinerMenu _dinerMenu;
        //private readonly PancakeHouseMenu _pancakeMenu;
        //private readonly CafeMenu _cafeMenu;

        //public Waitress(DinerMenu dinerMenu, PancakeHouseMenu pancakeMenu, CafeMenu cafeMenu)
        //{
        //    _dinerMenu = dinerMenu;
        //    _pancakeMenu = pancakeMenu;
        //    _cafeMenu = cafeMenu;
        //}

        private readonly IMenu _dinerMenu;
        private readonly IMenu _pancakeMenu;
        private readonly IMenu _cafeMenu;
        private readonly List<IMenu> _menuList;

        public Waitress(List<IMenu> menuList)
        {
            _menuList = menuList;
        }

        public Waitress(IMenu dinerMenu, IMenu pancakeMenu, IMenu cafeMenu)
        {
            _dinerMenu = dinerMenu;
            _pancakeMenu = pancakeMenu;
            _cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            IMenuIterator pancakeIterator = _pancakeMenu.CreateIterator();
            Console.WriteLine("\nBREAKFAST");
            DisplayMenu(pancakeIterator);

            IMenuIterator dinerIterator = _dinerMenu.CreateIterator();
            Console.WriteLine("\nLUNCH");
            DisplayMenu(dinerIterator);

            IMenuIterator cafeIterator = _cafeMenu.CreateIterator();
            Console.WriteLine("\nCAFE");
            DisplayMenu(cafeIterator);
        }

        public void PrintMenu2()
        {
            foreach (var menu in _menuList)
            {
                IMenuIterator menuIterator = menu.CreateIterator();
                DisplayMenu(menuIterator);
                Console.WriteLine();
            }
        }

        private void DisplayMenu(IMenuIterator menuIterator)
        {
            while (menuIterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)menuIterator.Next();
                Console.Write($"{menuItem.Name}, ");
                Console.Write($"{menuItem.Price}, -- ");
                Console.WriteLine($"{menuItem.Description}");
            }
        }
    }
}
