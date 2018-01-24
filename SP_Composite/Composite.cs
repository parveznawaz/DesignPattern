using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Composite
{
	public class Composite : Component
	{
		private List<Component> _children = new List<Component>();
		public Composite(string name) : base(name)
		{
		}

		public override void Add(Component c)
		{
			_children.Add(c);
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new String('-', depth) + name);
			foreach(var compo in _children)
			{
				compo.Display(depth + 2);
			}
		}

		public override void Remove(Component c)
		{
			_children.Remove(c);
		}
	}
}
