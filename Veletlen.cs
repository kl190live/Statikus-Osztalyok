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
		public enum NEM
		{ 
			FERFI,
			NO
		}


		private static Random RND = new Random();
		private static List<string> VEZETEKNEVEK=Feltolt("files/veznev.txt");
		private static List<string> FERFI_KERESZTNEVEK = Feltolt("files/ferfikernev.txt");
		private static List<string> NOI_KERESZTNEVEK = Feltolt("files/noikernev.txt");

		private static List<string> Feltolt(string fajlnev)
		{ 
			var list = new List<string>();

			using (StreamReader sr=new StreamReader(fajlnev))
			{ 
				while (!sr.EndOfStream) 
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

		public static string VelVezetekNev()
		{ 
			return VEZETEKNEVEK[RND.Next(VEZETEKNEVEK.Count)];
		}

		private static string VelFerfiKeresztnev()
		{
			return FERFI_KERESZTNEVEK[RND.Next(FERFI_KERESZTNEVEK.Count)];
		}
		private static string VelNoiKeresztnev()
		{
			return NOI_KERESZTNEVEK[RND.Next(NOI_KERESZTNEVEK.Count)];
		}


		public static string VelKeresztNev(NEM nem)
		{
			if (nem == NEM.FERFI)
			{
				return VelFerfiKeresztnev();
			}
			else
			{
				return VelNoiKeresztnev();
			}
		}

		public static string VelTeljesNev(NEM nem)
		{ 
			return VelVezetekNev()+" "+VelKeresztNev(nem);
		}


	}
}
