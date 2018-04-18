using System.Collections;
using IteratorPattern.ConcreteIterator;

namespace IteratorPattern.ConcreteAggregate
{
    public class CafeMenu : IMenu
    {
        private readonly Hashtable _menuItems;        

        public CafeMenu()
        {
            _menuItems = new Hashtable();

            AddItem("Veggie Burger and French Fries", "Veggie burger on a whole wheat bun, lettuce, tomoat and fries", true, 8.99);
            AddItem("Soup of the day", "A cup of today's soup with salad", true, 5.99);
            AddItem("Burrito", "A large Burrito with kidney beans and guacamole", true, 4.99);
        }

        public IMenuIterator CreateIterator()
        {
            return new CafeMenuIterator(_menuItems);
        }

        public Hashtable GetMenuItems()
        {
            return _menuItems;
        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            _menuItems.Add(name, new MenuItem(name, description, isVegetarian, price));
        }
    }
}
