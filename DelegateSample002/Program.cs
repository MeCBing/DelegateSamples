using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample002
{
    public delegate bool MyPredicate(string value,string v);
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source = new List<string> { "Bill", "John", "David", "Tom", "David" };
            MyPredicate predicate = SearchDavid;
            MyClass myClass = new MyClass();
            Console.Write("Ender :");
            string s = Console.ReadLine();
            var result = myClass.DoWhere(source, predicate,s);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
        static bool SearchDavid(string value,string v)
        {
            return (value == v);
        }

    }
    public class MyClass
    {
        public List<string> DoWhere(List<string> source, MyPredicate predicate,string s)
        {
            List<string> result = new List<string>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item,s))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
