﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Singleton
{
	public class Singleton
	{
		private static Singleton _instance;

		private Singleton() { }

		public static Singleton getInstance()
		{
			if (_instance == null)
			{
				_instance = new Singleton();
			}
			return _instance;
		}
	}
}
