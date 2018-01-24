using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Prototype
{
	public abstract class Prototype
	{
		private string _id;
		public Prototype(string id)
		{
			_id = id;
		}

		public string Id
		{
			get { return _id; }
		}

		public abstract Prototype Clone();
	}
}
