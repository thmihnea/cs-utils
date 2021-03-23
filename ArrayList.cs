using Collections;

class ArrayList<T> : List<T>
{
    private object[] _elements;
    private int _size;

    public ArrayList()
    {
        this._size = 0;
        this._elements = new object[Arrays.DEFAULT_BUFFER];
    }

    public ArrayList(int buffer)
    {
        this._size = 0;
        this._elements = new object[buffer];
    }

    private bool hasSpace()
    {
        return this._size < this._elements.Length - 1;
    }

    public void add(int index, T element)
    {
        throw new System.NotImplementedException();
    }

    public bool add(T element)
    {
        if (!this.hasSpace())
        {
            this._elements = Arrays.malloc(this._elements);
        }
        try
        {
            this._elements[this._size] = element;
            return true;
        } catch (System.Exception e)
        {
            return false;
        }
    }

    public bool addAll<T1>(Collection<T1> collection) where T1 : T
    {
        throw new System.NotImplementedException();
    }

    public void clear()
    {
        throw new System.NotImplementedException();
    }

    public bool contains(object obj)
    {
        throw new System.NotImplementedException();
    }

    public bool containsAll<T1>(Collection<T1> collection)
    {
        throw new System.NotImplementedException();
    }

    public T get(int index)
    {
        throw new System.NotImplementedException();
    }

    public int getSize()
    {
        throw new System.NotImplementedException();
    }

    public List<T> getSubList(int fromIndex, int toIndex)
    {
        throw new System.NotImplementedException();
    }

    public int indexOf(object obj)
    {
        throw new System.NotImplementedException();
    }

    public bool isEmpty()
    {
        throw new System.NotImplementedException();
    }

    public int lastIndexOf(object obj)
    {
        throw new System.NotImplementedException();
    }

    public bool remove(int index)
    {
        throw new System.NotImplementedException();
    }

    public bool remove(object obj)
    {
        throw new System.NotImplementedException();
    }

    public bool removeAll<T1>(Collection<T1> collection)
    {
        throw new System.NotImplementedException();
    }

    public bool removeIf<T1>(System.Predicate<T1> filter)
    {
        throw new System.NotImplementedException();
    }

    public void set(int index, T element)
    {
        throw new System.NotImplementedException();
    }

    public T[] toArray()
    {
        throw new System.NotImplementedException();
    }
}
