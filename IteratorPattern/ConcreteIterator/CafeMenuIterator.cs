using System.Collections;

namespace IteratorPattern.ConcreteIterator
{
    public class CafeMenuIterator : IMenuIterator
    {
        private readonly IEnumerator _iterator;

        public CafeMenuIterator(Hashtable menuItems)
        {
            // We are iterating through the values, so get the enumerator for the hashtable values
            _iterator = menuItems.Values.GetEnumerator();
        }

        public bool HasNext()
        {
            return _iterator.MoveNext();
        }

        public object Next()
        {
            return _iterator.Current;
        }
    }
}
