using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
	public class InjectedClass : IInjectedInterface
	{
		public string GetTest()
		{
			return "Test";
		}
	}
}
