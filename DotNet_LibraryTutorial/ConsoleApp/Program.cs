﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Hello Word\" from ConsoleApp.");

            //Library Code
            MyClass myClass = new MyClass("Tom");

            myClass.SayHello();

            Console.ReadKey();
        }
    }
}
