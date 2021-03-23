using System;

namespace Collections
{
    interface Collection<E>
    {
        int getSize();

        bool isEmpty();

        bool contains(object obj);

        E[] toArray();

        bool add(E element);

        bool remove(object obj);

        bool containsAll<T>(Collection<T> collection);

        bool addAll<T>(Collection<T> collection) where T : E;

        bool removeAll<T>(Collection<T> collection);

        bool removeIf<T>(Predicate<T> filter);

        void clear();
    }

    interface List<E> : Collection<E>
    {
        E get(int index);

        void set(int index, E element);

        void add(int index, E element);

        bool remove(int index);

        int indexOf(object obj);

        int lastIndexOf(object obj);

        List<E> getSubList(int fromIndex, int toIndex);
    }
}
