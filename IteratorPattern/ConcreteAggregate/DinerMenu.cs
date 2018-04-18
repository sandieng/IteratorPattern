using System;
using IteratorPattern.ConcreteIterator;

namespace IteratorPattern.ConcreteAggregate
{
    public class DinerMenu : IMenu
    {
        private readonly int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "Mock Bacon with Lettuce & Tomato", true, 2.99);
            AddItem("Porter Steak", "House Porter Steak with mushroom sauce", false, 22.99);
        }

        public IMenuIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add more.");
                return;
            }

            _menuItems[_numberOfItems] = menuItem;
            _numberOfItems += 1;
        }
    }
}
