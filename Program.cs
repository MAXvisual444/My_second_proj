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
			if (x > 2017)
			{
				Console.WriteLine("Ты либо из будущего, либо балобол.");
				Console.WriteLine("Что то я не вижу рядом машину времени...");
			}
			else if (x > 2010)
			{
				Console.WriteLine("Ути пути какой малыш");
			}
		
			Console.ReadKey();
        }
    }
}


