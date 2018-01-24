using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class Factory2 : AbstractFactory
	{
		public override AbstractProductA CreateProductA()
		{
			return new ProductA2();
		}

		public override AbstractProductB CreateProductB()
		{
			return new ProductB2();
		}
	}
}
