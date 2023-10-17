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
			File.ReadAllLines(fajlnev).ToList();
			using (StreamReader sr=new StreamReader(fajlnev))
			{ 
				while (!sr.EndOfStream) 
				{
					var line = sr.ReadLine();
					list.Add(line);
				}
			}

			return list;
			//File.ReadAllLines(fajlnev).ToList();
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

			public static string VelDatum(int ev1, int ev2)
			{
				if (ev1 > ev2)
				{
					int temp = ev1;
					ev1 = ev2;
					ev2 = temp;
				}



				int ev = RND.Next(ev1, ev2 + 1);
				int honap = RND.Next(1, 13);
				int nap = RND.Next(1, DateTime.DaysInMonth(ev, honap) + 1);



				DateTime datum = new DateTime(ev, honap, nap);
				return datum.ToString("yyyy-MM-dd");
			}

		public static string VelEmail(string nev)
		{
			NEM nem = new NEM();
			nev = VelTeljesNev(nem).ToLower();
			for (int i = 0; i < nev.Length; i++)
			{
				switch (nev[i])
				{
					case 'á': nev += 'a'; break;
					case 'é': nev += 'e'; break;
					case 'í': nev += 'i'; break;
					case 'ö': nev += 'o'; break;
					case 'ő': nev += 'o'; break;
					case 'ó': nev += 'o'; break;
					case 'ú': nev += 'u'; break;
					case 'ü': nev += 'u'; break;
					case 'ű': nev += 'u'; break;
					default: nev += nev[i]; break;
				}
				
				return nev + "@gmail.com";
			}

		}
	}
}
