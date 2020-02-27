using System;

class Program
{
    static void Main()
    {
        string str = "Apple Bapple Capple Dapple Eapple";
        string[] arr = str.Split(' ');
        foreach (string s in arr)
            Console.WriteLine(s);
    }
}
