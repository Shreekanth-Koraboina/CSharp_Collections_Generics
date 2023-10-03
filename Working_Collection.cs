using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SortedList_String();
        }

        public static void List_Add()
        {
            //Create collection class
            List<string> names = new List<string>();
            names.Add("Srinivas");
            names.Add("Sreekanth");
            names.Add("Arjun");
            names.Add("Surya");

            //Iterate list element using foreach loop
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        public static void List_Assign()
        {

            //Creating a string list collection using initializer
            List<string> names = new List<string>() { "Arjun", "Srinivas", "Sreekanth", "Surya" };
            //Creating a int list collection using initializer
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            //iterate through the interger list
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

            //iterate through the list
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }

        public static void HashSet_String()
        {
            //Create a set of Strings
            var names = new HashSet<string>();
            names.Add("1");
            names.Add("1");
            names.Add("2");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //Creating a HashSet using initializer
            var numbers = new HashSet<string>() { "One", "Two", "Three", "Four", "Two" };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

        }

        public static void SortedSet_String()
        {
            //Create a set of strings
            var numbers = new SortedSet<int>();
            numbers.Add(3);
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(2);
            numbers.Add(3);

            foreach (var name in numbers)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

            var strNumbers = new SortedSet<string>() { "One", "Two", "Three", "Four", "Two" };
            foreach (var strNumber in strNumbers)
            {
                Console.WriteLine(strNumber);
            }
            Console.ReadLine();
        }

        public static void Stack_String()
        {
            Stack<string> names = new Stack<string>();
            names.Push("1");
            names.Push("2");
            names.Push("3");
            names.Push("4");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            Console.WriteLine("Peek Element : " + names.Peek());
            Console.WriteLine("Pop : " + names.Pop());
            Console.WriteLine("After Pop Peek element : " + names.Peek());
            Console.ReadLine();

        }

        public static void Queue_String()
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("1");
            names.Enqueue("2");
            names.Enqueue("3");
            names.Enqueue("4");
            names.Enqueue("5");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek Element : " + names.Peek());
            Console.WriteLine("Dequeue : " + names.Dequeue());
            Console.WriteLine("After Dequeue , Peek Element : " + names.Peek());
        }

        public static void LinkedList_String()
        {
            //Create a List of String
            var names = new LinkedList<string>();
            names.AddLast("1");
            names.AddLast("2");
            names.AddLast("3");
            names.AddLast("4");
            names.AddFirst("0");//Added to first Index

            //Iterate list element using for each loop
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
            //insert new element before peter
            LinkedListNode<string> node = names.Find("3");
            names.AddBefore(node, "5");
            names.AddAfter(node, "6");

            //Iterate first element using foreach loop
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }

        public static void Dictonory_Key_Value()
        {
            //String Dictonory
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "One");
            names.Add("2", "Two");
            names.Add("3", "Three");

            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
            Console.ReadLine();

            //Integer Dictonory
            Dictionary<int, string> dictNames = new Dictionary<int, string>();
            dictNames.Add(4, "Four");
            dictNames.Add(5, "Five");
            dictNames.Add(6, "Six");
            foreach (KeyValuePair<int, string> kp in dictNames)
            {
                Console.WriteLine(kp.Key + "  " + kp.Value);
            }
            Console.ReadLine();

        }

        public static void SortedDictonory_String()
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("3", "One");
            names.Add("2", "Two");
            names.Add("1", "Three");
            foreach (KeyValuePair<string, string> kvp in names)
            {
                Console.WriteLine(kvp.Key + "  " + kvp.Value);
            }
        }

        public static void SortedList_String()
        {
            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("1", "One");
            names.Add("3", "Three");
            names.Add("0", "Zero");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
