using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatProjekt
{
	public class SenkiSemIrtException : Exception
	{
		public SenkiSemIrtException(string message) : base(message)
		{
		}
	}
}
