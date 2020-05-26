namespace Common.Communication.Writer
{
	public interface IGenerateData
	{
		void GenerateData();

		void SendData(string line);

		void ReadData();
	}
}