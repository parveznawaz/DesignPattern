using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Adapter
{
	public class Adapter: Target
	{
		private Adaptee _adaptee = new Adaptee();
		public override void Request()
		{
			_adaptee.SpecificRequest();
		}
	}
}
