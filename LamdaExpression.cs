using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    public class LamdaExpression
    {
        public static void Main(string[] arg)
        {
            List<string> myList = new List<string>();
            myList.Add("1");
            myList.Add("2");
            myList.Add("3");
            myList.Add("4");

            myList.ForEach(a => Console.WriteLine(a));
            Console.ReadLine();

            myList.ForEach(i => Console.WriteLine(i));
            Console.ReadLine();

            myList.ForEach(y => Console.WriteLine(y));
            Console.ReadLine();

        }
    }
}
