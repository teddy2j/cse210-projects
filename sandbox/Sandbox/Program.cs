using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int value=1;
        while (value <10)
        {
            Console.Read();
            Console.WriteLine("hola amigo");
            value ++;
        }
    }
}
