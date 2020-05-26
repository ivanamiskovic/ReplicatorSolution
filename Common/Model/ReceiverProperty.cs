using Common.Model.Enums;
using System.Runtime.Serialization;

namespace Common.Model
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