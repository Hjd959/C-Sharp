using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            cat newcat = new cat();

            Console.Write("type:");
           
            newcat.type = Console.ReadLine();

            Console.Write("Enter weight");
            newcat.weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter color");
            newcat.color = Convert.ToInt32(Console.ReadLine());



             Console.WriteLine(newcat.getNameAndType());
              Console.ReadLine();


        }
    }
}
