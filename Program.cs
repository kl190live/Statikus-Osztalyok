using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statikus_Osztalyok
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // Veletlen v = new Veletlen();

            Console.WriteLine(Veletlen.VelEgesz(2,60));
			for (int i = 0; i < 10; i++) 
			{ 
            Console.WriteLine(Veletlen.VelKarakter('A','D'));
			}
			for (int i = 0; i < 5; i++)
			{
                Console.WriteLine(Veletlen.VelTeljesNev(Veletlen.NEM.FERFI));
				Console.WriteLine(Veletlen.VelTeljesNev(Veletlen.NEM.NO));
			}

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(Veletlen.VelEmail(""));
			}

		}



	}
}
