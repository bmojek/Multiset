using System;
using MultisetClassLibrary;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Multiset<char> m = new Multiset<char>();
            m.Add('a');
            m.Add('a');
            m.Add('a');
            m.Add('a');
            m.Add('a');
            m.Add('a');
            m.Add('a');
            m.Add('b');
            m.Add('b');
            m.Add('b');
            m.Add('b');
            m.Add('b');
            m.Add('a');
            Console.WriteLine(m.GetIndex('b'));
            
        }
    }
}
