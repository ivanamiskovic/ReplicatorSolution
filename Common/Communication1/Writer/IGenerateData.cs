using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication1.Writer
{
	public interface IGenerateData
	{
		void GenerateData();

		void SendData(string line);

		void ReadData();
	}
}