using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Composite
{
	public class Leaf : Component
	{
		public Leaf(string name) : base(name)
		{
		}

		public override void Add(Component c)
		{
			Console.WriteLine("Can not add to leaf");
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new String('-',depth) + name);
		}

		public override void Remove(Component c)
		{
			Console.WriteLine("Cannot remove from a leaf");
		}
	}
}
