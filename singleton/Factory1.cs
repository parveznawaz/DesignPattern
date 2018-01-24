﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class Factory1 : AbstractFactory
	{
		public override AbstractProductA CreateProductA()
		{
			return new ProductA1();
		}

		public override AbstractProductB CreateProductB()
		{
			return new ProductB1();
		}
	}
}
