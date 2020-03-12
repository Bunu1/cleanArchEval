using System;
using cleanArch.Core;

namespace cleanArch.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PostIt postIt = new PostIt(new DateTime(2020, 3, 2, 10, 0, 0), "title", "content");
            postIt.getPostItAge(new DefaultClock());
        }
    }
}
