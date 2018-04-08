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

			switch (x)
			{
				case 1:
					Console.WriteLine("Число 1");
					break;
				case 2:
					Console.WriteLine("Число 2");
					break;
				case 3:
					Console.WriteLine("Число 3");
					break;
				default:
					Console.WriteLine("Какое-то x3 какое число");
					break;
			}
			Console.WriteLine("всё");
			Console.ReadKey();
        }
    }
}


