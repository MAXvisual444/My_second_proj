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
			Console.WriteLine("46");
			string text = Console.ReadLine();
			int years = Convert.ToInt32(text);
			if (years > 16)
			{
				Console.WriteLine("Tooooo old");
			}
			else
			{
				Console.WriteLine("Тесак уже выезжал за тобой");
			}
			Console.ReadKey();
        }
    }
}


