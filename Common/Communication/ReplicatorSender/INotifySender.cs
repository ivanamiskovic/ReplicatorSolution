using Common.Model;


namespace Common.Communication.ReplicatorSender
{
		public interface INotifySender
	{
		
		void Write(ReceiverProperty receiverProperty);

		void ForwardToReciver();

		void QueueAndSend();
	}
}