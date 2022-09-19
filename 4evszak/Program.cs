using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4evszak
{
	class Program
	{
		static void Main(string[] args)
		{
			int honap = 9;
			string evszak = string.Empty;
			switch(honap)
			{
				case 12:
				case 1:
				case 2:
					evszak = "tél";
					break;
				case 3:
				case 4:
				case 5:
					evszak = "tavasz";
					break;
				case 6:
				case 7:
				case 8:
					evszak = "nyár";
					break;
				case 9:
				case 10:
				case 11:
					evszak = "ősz";
					break;

				default:
					break;
			}
			Console.WriteLine($"{honap}.hónap {evszak} évszakban van");
			Console.ReadKey();
		}
	}
}
