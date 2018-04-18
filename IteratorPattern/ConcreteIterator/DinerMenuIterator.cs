namespace IteratorPattern.ConcreteIterator
{
    public class DinerMenuIterator : IMenuIterator
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return (_position < _items.Length && _items[_position] != null);
        }

        public object Next()
        {
            MenuItem menuItem = _items[_position];
            _position += 1;
            return menuItem;
        }
    }
}
