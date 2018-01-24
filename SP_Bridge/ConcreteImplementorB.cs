using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Bridge
{
	public class ConcreteImplementorB : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("Concrete Implementor B operation");
		}
	}
}
