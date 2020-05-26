using Common.Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace Common.Communication1.ReplicatorSender
{
	[ServiceContract] 
	public interface INotifySender
	{
		[OperationContract]
		void Write(ReceiverProperty receiverProperty);

		void ForwardToReciver();

		void QueueAndSend();
	}
}