using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
	[DataContract]
	public class ReciverValue
	{
		[DataMember]
		public int IdGeography { get; set; }

		[DataMember]
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