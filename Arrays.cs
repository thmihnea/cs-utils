using System;
using System.Collections.Generic;
using System.Text;

class Arrays
{
    public static int DEFAULT_BUFFER = 8;

    public static T[] malloc<T>(T[] array)
    {
        return malloc(array, DEFAULT_BUFFER);
    }

    public static T[] malloc<T>(T[] array, int buffer)
    {
        int current_size = array.Length;
        T[] new_array = new T[current_size + buffer];
        for (int i = 0; i < current_size + buffer; i++)
        {
            new_array[i] = array[i];
        }
        return new_array;
    }

    public static T[] copy<T>(T[] array)
    {
        int current_size = array.Length;
        T[] array_copy = new T[current_size];
        for (int i = 0; i < current_size; i++)
        {
            array_copy[i] = array[i];
        }
        return array_copy;
    }

    public static T[] copyAndMalloc<T>(T[] array, int buffer)
    {
        int current_size = array.Length;
        T[] array_copy = new T[current_size + buffer];
        for (int i = 0; i < current_size; i++)
        {
            array_copy[i] = array[i];
        }
        return array_copy;
    }
}
