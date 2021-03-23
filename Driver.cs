using Collections;
using System;

class Driver
{
    public static void Main(string[] args)
    {
        List<string> list = new ArrayList<string>();
        list.add("a");
        list.add("b");
        list.add("b");
        list.add("b");
        list.remove(1);
        foreach(string s in list.toArray())
        {
            Console.WriteLine(s);
        }
        Console.WriteLine(list.getSize());
        Console.WriteLine(list.isEmpty());
    }
}
