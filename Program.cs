using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VySeconddApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите число:");
			string x = Console.ReadLine();
			int a = Convert.ToInt32(x);
			a = a * a;
			Console.WriteLine(a);
			Console.ReadKey();
        }
    }
}


