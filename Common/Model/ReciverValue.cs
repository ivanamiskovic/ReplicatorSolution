using System.Runtime.Serialization;

namespace Common.Model
{
	
	public class ReciverValue
	{
		
		public int IdGeography { get; set; }

		
		public double Consumtion { get; set; }

		public ReciverValue()
		{
		}

		public ReciverValue(int idGeography, double consumtion)
		{
			IdGeography = idGeography;
			Consumtion = consumtion;
		}
	}
}