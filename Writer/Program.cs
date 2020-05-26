using Common;
using Common.Communication.Connection;
using Common.Communication.Writer;
using Common.Utility;
using System;

namespace Writer
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