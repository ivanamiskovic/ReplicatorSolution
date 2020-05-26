using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model1
{
	public class ReceiverProperty
	{

		public string Code { get; set; }


		public ReciverValue ReciverValue { get; set; }

		public ReceiverProperty()
		{
		}

		public ReceiverProperty(string code, ReciverValue reciverValue)
		{
			Code = code;
			ReciverValue = reciverValue;
		}
	}
}
