using Common.Model;
using Common.Model1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Writer1
{
	

		public class DataGenerator : IGenerateData
		{
			private IConnect<INotifySender> connecter;

			private string file = @"C:\Users\Ivana\Desktop\RES_Ivana_Miskovic-master\dataset.txt";

			public DataGenerator(IConnect<INotifySender> connecter)
			{
				this.connecter = connecter;
			}


			public void GenerateData()
			{

				new Task(() =>
				{
					while (true)
					{
						ReadData();

						Thread.Sleep(2000);
					}
				}).Start();
			}

			public void ReadData()
			{
				List<string> lines = File.ReadAllLines(file).ToList();
				foreach (var line in lines)
				{
					SendData(line);
				}
			}


			public void SendData(string line)
			{
				string[] entries = line.Split(',');

				string code = entries[0];
				int geographyID = Convert.ToInt32(entries[1]);
				double consumption = Convert.ToDouble(entries[2]);
				ReceiverProperty receiver = new ReceiverProperty(code, new ReciverValue(geographyID, consumption));

				connecter.ReturnProxy().Write(receiver);
				string message = $"Writer send new ReciverProperty to Replicator Sender - Code: {code}, " +
					$"GeographyID: {geographyID}, Consumption: {consumption}";

				Console.WriteLine(message);
			}
		}
	}

