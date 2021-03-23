using System;

class Driver
{
    public static void Main(string[] args)
    {
        object[] s = new object[] { "asd", 12, "cock" };
        s = Arrays.malloc(s, -1);
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i]);
        }
    }
}
