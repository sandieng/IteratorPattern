using System;

namespace IteratorPattern
{
    public interface IMenuIterator
    {
        bool HasNext();
        Object Next();
    }
}
