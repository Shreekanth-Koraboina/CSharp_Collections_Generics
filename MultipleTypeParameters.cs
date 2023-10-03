using System;
namespace CollectionsDemo
{
    public class MultipleTypeParameters
    {
       public void Dispaly<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0} : {1}", msg, value);
        }
    }

    public class Example
    {
        public static int Main(String[] arg)
        {
            MultipleTypeParameters obj = new MultipleTypeParameters();
            obj.Dispaly<int>("Integer", 122);
            obj.Dispaly<char>("Character", 'H');
            obj.Dispaly<double>("Decimal", 255.5);
            return 0;
        }
    }
}
