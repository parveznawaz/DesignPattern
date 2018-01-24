using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Prototype
{
	public class ConcreatePrototype2 : Prototype
	{
		public ConcreatePrototype2(string id) : base(id)
		{
		}

		public override Prototype Clone()
		{
			return (Prototype)this.MemberwiseClone();
		}
	}
}
