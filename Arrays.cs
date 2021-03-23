using System;
using System.Collections.Generic;
using System.Text;

class Arrays
{
    public static int DEFAULT_BUFFER = 8;

    public static object[] malloc(object[] array)
    {
        return malloc(array, DEFAULT_BUFFER);
    }

    public static object[] malloc(object[] array, int buffer)
    {
        int current_size = array.Length;
        object[] new_array = new object[current_size + buffer];
        for (int i = 0; i < current_size + buffer; i++)
        {
            new_array[i] = array[i];
        }
        return new_array;
    }

    public static object[] copy(object[] array)
    {
        int current_size = array.Length;
        object[] array_copy = new object[current_size];
        for (int i = 0; i < current_size; i++)
        {
            array_copy[i] = array[i];
        }
        return array_copy;
    }

    public static object[] copyAndMalloc(object[] array, int buffer)
    {
        int current_size = array.Length;
        object[] array_copy = new object[current_size + buffer];
        for (int i = 0; i < current_size; i++)
        {
            array_copy[i] = array[i];
        }
        return array_copy;
    }
}
