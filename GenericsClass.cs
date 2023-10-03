//C# program to show working of user
//defined Generic classes

using System;
namespace CollectionsDemo
{
    public class GenericsClass<T>
    {
        //Private data memebrs
        private T data;

        //using properties
        public T value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

    }

    class Test
    {
        public static void Main(String[] arg )
        {
            //instane of the string type
            GenericsClass<string> name = new GenericsClass<string>();
            name.value = "Arjun is Awesome";


            //instance of float type
            GenericsClass<float> version = new GenericsClass<float>();
            version.value = 5;


            Console.WriteLine(name.value);
            Console.WriteLine(version.value);

        }
    }
}


