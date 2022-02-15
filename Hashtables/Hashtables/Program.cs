using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            MyMapNode<int, string> find = new MyMapNode<int, string>(5);          
            find.Add(0, "to");
            find.Add(1, "be");
            find.Add(2, "or");
            find.Add(3, "not");
            find.Add(4, "to");
            find.Add(5, "be");          
            find.Findthefrequency("to");
            find.Findthefrequency("be");
            find.Findthefrequency("or");
            find.Findthefrequency("not");
            Console.ReadKey();
        }
    }
}
