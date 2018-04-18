using System.Collections.Generic;
using IteratorPattern.ConcreteIterator;

namespace IteratorPattern.ConcreteAggregate
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();

            AddItem("K&B's Pancake Breakfast", "Pancake with scrambled eggs and toast", true, 10.99);
            AddItem("Regular Pancake Breakfast", "Pancake with fried eggs and bacon", false, 12.99);
            AddItem("Blueberries Pancake Breakfast", "Pancake with blueberris and toast", true, 7.99);
        }

        public IMenuIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }

        public List<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            _menuItems.Add(new MenuItem(name, description, isVegetarian, price));
        }
    }
}
