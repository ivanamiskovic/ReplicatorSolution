using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writer1
{
	internal class Program
	{

		private static IConnect<INotifySender> connecter;

		private static IGenerateData dataGenerator;


		private static void Main(string[] args)
		{


			dataGenerator = new DataGenerator(connecter);
			dataGenerator.GenerateData();

			Console.WriteLine("Press enter to close Writer: ");
			Console.ReadLine();
		}
	}
}
