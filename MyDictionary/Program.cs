using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string> () ;
            myDictionary.Add(1 , "Muz");
            myDictionary.Add(2 , "Armut");
            myDictionary.Add(3 , "Portakal" );
            myDictionary.Add(4 , "Kereviz");
            myDictionary.Add(5 , "Ispanak");
            myDictionary.Show();

        }
    }
}
