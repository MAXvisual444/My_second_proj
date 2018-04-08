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
			Console.WriteLine("040273");
			string text = Console.ReadLine();
			int x = Convert.ToInt32(text);

			string result = x > 100 ? "больше 100" : "меньше 100";
			Console.WriteLine("Результат" + result);
			Console.ReadKey();
        }
    }
}


