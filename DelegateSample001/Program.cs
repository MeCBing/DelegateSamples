using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample001
{
    //public delegate void SomeAction(string message,int mes);
    public delegate void SomeAction(string message);
    class Program
    {
        static void Main(string[] args)
        {
            SomeAction action1 = new SomeAction(ShowText);
            action1 += ShowMessage;
            SomeAction action2 = ShowText;
            action1.Invoke("");
            action2(" => Action2");
            Console.ReadLine();
        }
        static void ShowText(string msg)
        {
            Console.WriteLine($"ShowText {msg}");
        }
        static void ShowMessage(string str)
        {
            Console.WriteLine($"ShowMessage {str}");
        }
    }
}
