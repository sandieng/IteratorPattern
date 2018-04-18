using System;

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
