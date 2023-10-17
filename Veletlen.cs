using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statikus_Osztalyok
{
	internal static class Veletlen
	{
		// private string abc;
		private static Random RND = new Random();
		private static List<string> VEZETEKNEVEK=Feltolt("files/veznev.txt");
		private static List<string> FERFI_KERESZTNEVEK = Feltolt("files/ferfikernev.txt");
		private static List<string> NOI_KERESZTNEVEK = Feltolt("files/noikernev.txt");

		private static List<string> Feltolt(string fajlnev)
		{ 
			var list = new List<string>();

			using (StreamReader sr=new StreamReader(fajlnev))
			{ 
				while (sr.EndOfStream) 
				{
					var line = sr.ReadLine();
					list.Add(line);
				}
			}

			return list;
		}

		public static int VelEgesz(int min, int max)
		{ 
			return RND.Next(min, max+1);
		}

		public static char VelKarakter(char min, char max)
		{
			return (char)VelEgesz(min,max);
		}

	}
}
