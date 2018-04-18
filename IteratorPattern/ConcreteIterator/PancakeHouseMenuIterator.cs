using System;
using System.Collections.Generic;

namespace IteratorPattern.ConcreteIterator
{
    public class PancakeHouseMenuIterator : IMenuIterator
    {       
        private readonly IEnumerator<MenuItem> _iterator;
        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            _iterator = menuItems.GetEnumerator();
        }

        public bool HasNext()
        {
            return _iterator.MoveNext(); ;
        }

        public Object Next()
        {
            return _iterator.Current;
        }
    }
}
