using Collections;

class ArrayList<T> : List<T>
{
    private T[] _elements;
    private int _size;

    public ArrayList()
    {
        this._size = 0;
        this._elements = new T[Arrays.DEFAULT_BUFFER];
    }

    public ArrayList(int buffer)
    {
        this._size = 0;
        this._elements = new T[buffer];
    }

    private bool hasSpace()
    {
        return this._size < this._elements.Length - 1;
    }

    public void add(int index, T element)
    {
        if (!this.hasSpace())
        {
            this._elements = Arrays.malloc(this._elements);
        }
        this._size++;
        for (int i = this._size - 1; i >= index; i--)
        {
            this._elements[i + 1] = this._elements[i];
        }
        this._elements[index] = element;
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
            this._size++;
            return true;
        } catch (System.Exception e)
        {
            return false;
        }
    }

    public void clear()
    {
        this._elements = Arrays.malloc(this._elements, -this._elements.Length + Arrays.DEFAULT_BUFFER);
        for (int i = 0; i < this._elements.Length; i++)
        {
            this._elements[i] = default(T);
        }
        this._size = 0;
    }

    public bool contains(object obj)
    {
        if (this._size == 0) return false;
        return this.search(obj, 0, this._size - 1) > 0;
    }

    private int search(object obj, int left, int right)
    {
        if (left == right)
        {
            return (this._elements[left].Equals(obj)) ? 1 : 0;
        } 
        else
        {
            int middle = (left + right) / 2;
            return this.search(obj, left, middle) + this.search(obj, middle + 1, right);
        }
    }

    public T get(int index)
    {
        if (index < 0 || index >= this._size) return default(T);
        return this._elements[index];
    }

    public int getSize()
    {
        return this._size;
    }

    public List<T> getSubList(int fromIndex, int toIndex)
    {
        List<T> subList = new ArrayList<T>();
        for (int i = fromIndex; i <= toIndex; i++)
        {
            subList.add(this.get(i));
        }
        return subList;
    }

    public int indexOf(object obj)
    {
        if (this._size == 0) return -1;
        for (int i = 0; i < this._size - 1; i++)
        {
            if (obj.Equals(this._elements[i])) return i;
        }
        return -1;
    }

    public bool isEmpty()
    {
        return this._size == 0;
    }

    public int lastIndexOf(object obj)
    {
        if (this._size == 0) return -1;
        for (int i = this._size - 1; i >= 0; i--)
        {
            if (obj.Equals(this._elements[i])) return i;
        }
        return -1;
    }

    public bool remove(int index)
    {
        if (index < 0 || index >= this._size) return false;
        for (int i = index; i < this._size - 1; i++)
        {
            this._elements[i] = this._elements[i + 1];
        }
        this._elements[this._size - 1] = default(T);
        this._elements = Arrays.malloc(this._elements, -1);
        this._size--;
        return true;
    }

    public bool remove(object obj)
    {
        bool found = false;
        while (this.indexOf(obj) != -1)
        {
            found = true;
            this.remove(this.indexOf(obj));
        }
        return found;
    }

    public void set(int index, T element)
    {
        if (index < 0 || index >= this._size) return;
        this._elements[index] = element;
    }

    public T[] toArray()
    {
        return this._elements;
    }
}
