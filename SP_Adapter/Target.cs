﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Adapter
{
	public class Target
	{
		public virtual void Request()
		{
			Console.WriteLine("Called Target Request");
		}
	}
}
