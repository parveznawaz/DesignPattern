using System;
using System.Collections.Generic;
using System.Text;

namespace CP_AbstractFactory
{
  public abstract class AbstractFactory
    {
		public abstract AbstractProductA CreateProductA();
		public abstract AbstractProductB CreateProductB();
    }
}
