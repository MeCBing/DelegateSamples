using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source = new List<string> { "Bill", "John", "David", "Tom", "David" };
            MyClass myClass = new MyClass();
            Console.Write("Ender :");
            string s = Console.ReadLine();
            var result = myClass.DoWhere(source, (x) => x == s );
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    public class MyClass
    {
        public List<string> DoWhere(List<string> source, Func<string, bool> predicate )
        {
            List<string> result = new List<string>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
