using System;
using System.Collections.Generic;

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

        bool containsAll<T>(Collection<T> collection)
        {
            bool contains_all = false;
            foreach(T t in collection.toArray())
            {
                if (!this.contains(t)) contains_all = true;
            }
            return contains_all;
        }

        bool addAll<T>(Collection<T> collection) where T : E
        {
            foreach(T t in collection.toArray())
            {
                this.add(t);
            }
            return true;
        }

        bool removeAll<T>(Collection<T> collection)
        {
            foreach(T t in collection.toArray())
            {
                this.remove(t);
            }
            return true;
        }

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
