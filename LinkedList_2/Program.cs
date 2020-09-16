using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.Model;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new Model.LinkedList<int>();

            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            foreach (var item in linkedList)
                Console.WriteLine(item);

            linkedList.Delete(4);
            foreach (var item in linkedList)
                Console.WriteLine("\t" + item);                      

            var reverse = linkedList.Reverse();
            foreach (var item in reverse)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
