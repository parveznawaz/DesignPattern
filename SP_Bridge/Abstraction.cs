﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Bridge
{
	public class Abstraction
	{
		protected Implementor implementor;
		public Implementor Implementor
		{
			set { implementor = value; }
		}

		public virtual void Operation()
		{
			implementor.Operation();
		}
	}
}
