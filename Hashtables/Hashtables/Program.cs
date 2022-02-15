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
            int i = 0;
            string mystring = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";           
            string[] array = mystring.Split(' ');           
            foreach (var value in array)
            {
                find.Add(i, value);
                i++;
            }          
            find.Findthefrequency("paranoid");
            find.Findthefrequency("because");
            find.Findthefrequency("are");
            find.Findthefrequency("but");
            Console.ReadKey();
        }
    }
}
