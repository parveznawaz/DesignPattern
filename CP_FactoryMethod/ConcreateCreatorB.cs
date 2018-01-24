using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_FactoryMethod
{
	public class ConcreateCreatorB : Creator
	{
		public override Product FactoryMethod()
		{
			return new ConcreateProductB();
		}
	}
}
