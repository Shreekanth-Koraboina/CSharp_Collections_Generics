//C# to ilustrate the concept of
//non generic collection using Queue

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CollectionsDemo
{
    public class GFG
    {
        public static void Main(String[] arg)
        {
            //Console.ReadLine();
            //QueueExample();
            //Console.ReadLine();
            //ListExamaple();
            //Console.ReadLine();
            //CollectionClassExample();
            //Console.ReadLine();
            //CollectionClassExample2();
            //Console.ReadLine();
            CopyEntireCollection();

        }

        public static void QueueExample()
        {
            //Creating a Queue
            Queue queue = new Queue();


            //inserting elements in the Queue
            queue.Enqueue("C#");
            queue.Enqueue("PHP");
            queue.Enqueue("Perl");
            queue.Enqueue("Java");
            queue.Enqueue("C");


            //Displaying the count of elements contained in Queue
            Console.Write("Total Elements contained in the Queue Are: ");
            Console.WriteLine(queue.Count);

            //Displaying  the beginning element of the Queue
            Console.WriteLine("Beginning Item: " + queue.Peek());

        }

        public static void ListExamaple()
        {
            //Creating list of Integers
            List<int> myList = new List<int>();

            //Adding Items in list
            for (int j = 5; j < 10; j++)
            {
                myList.Add(j * 3);
            }


            //Displaying items of myList
            //By using foreach loop
            foreach (int items in myList)
            {
                Console.WriteLine(items);
            }

            //creating list of strings
            List<String> strList = new List<string>();


            //Adding stringitems in list
            for (int j = 5; j < 10; j++)
            {
                strList.Add("Arjun" + j.ToString());
            }
            Console.ReadLine();
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }

        }

        public static void CollectionClassExample()
        {

            //creating collection of integers
            Collection<int> myColl = new Collection<int>();

            //Adding elemets in collection myColl
            myColl.Add(2);
            myColl.Add(3);
            myColl.Add(4);
            myColl.Add(5);

            //Displaying elements in collection
            foreach(int i in myColl)
            {
                Console.WriteLine(i);
            }

        }

        public static void CollectionClassExample2()
        {
            //Creating a collection of string
            Collection<string> myColl = new Collection<string>();

            //Adding elelements in collection myColl
            myColl.Add("A");
            myColl.Add("B");
            myColl.Add("C");
            myColl.Add("D");
            myColl.Add("E");


            //----Count Property

            //To print the count of elements in the collections
            Console.WriteLine("Count: " + myColl.Count);

            //-----Item[Int32]-----

            Console.ReadLine();
            //Get element at index 2
            Console.WriteLine("Element at index 2 is : " + myColl[2]);
            //Get element at index 3
            Console.WriteLine("Element at index 3 is : " + myColl[3]);

            Console.ReadLine();
            //Check if an element is present in the collecttion
            Console.WriteLine(myColl.Contains("C"));


        }

        public static void CopyEntireCollection()
        {
            Collection<string> myColl = new Collection<string>();

            myColl.Add("A");
            myColl.Add("B");
            myColl.Add("C");
            myColl.Add("D");
            myColl.Add("E");

            //Creating string array
            string[] myArr = new string[myColl.Count];


            //Copy entire collection to a compabtable one dimentioal array
            //Starting at the specified index of the target array
            myColl.CopyTo(myArr, 0);

            //Displaying the elements in myArr
            foreach(string str in myArr)
            {
                Console.WriteLine(str);
            }

        }

    }
}
