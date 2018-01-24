using CP_AbstractFactory;
using CP_Builder;
using CP_FactoryMethod;
using CP_Prototype;
using CP_Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP_Adapter;
using SP_Bridge;
using SP_Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	[TestClass]
	public class CreationalPatternTests
	{
		[TestMethod]
		public void Check_Abstract_Factory_Returns_Correct_Objects()
		{
			AbstractFactory factory1 = new Factory1();
			AbstractProductA product1 = factory1.CreateProductA();
			AbstractProductB product2 = factory1.CreateProductB();
			Assert.AreEqual(product1.GetType(), typeof(ProductA1));
			Assert.AreEqual(product2.GetType(), typeof(ProductB1));
		}

		[TestMethod]
		public void Check_Builder_Pattern()
		{
			Director director = new Director();
			Builder b1 = new ConcreteBuilder1();
			director.Construct(b1);
			CP_Builder.Product p1 = b1.GetResult();
			p1.Show();

			Builder b2 = new ConcreteBuilder2();
			director.Construct(b2);
			CP_Builder.Product p2 = b2.GetResult();
			p2.Show();
		}

		[TestMethod]
		public void Check_Factory_Method()
		{
			Creator[] creators = new Creator[2];
			creators[0] = new ConcreateCreatorA();
			creators[1] = new ConcreateCreatorB();
			foreach(Creator creator in creators)
			{
				CP_FactoryMethod.Product product = creator.FactoryMethod();
				Console.WriteLine("Created {0}", product.GetType().Name);
			}
		}

		[TestMethod]
		public void Check_Prototype()
		{
			ConcreatePrototype1 p1 = new ConcreatePrototype1("I");
			ConcreatePrototype1 c1 = (ConcreatePrototype1)p1.Clone();
			Console.WriteLine("Cloned: {0}", c1.Id);

			ConcreatePrototype2 p2 = new ConcreatePrototype2("II");
			ConcreatePrototype2 c2 = (ConcreatePrototype2)p2.Clone();
			Console.WriteLine("Cloned: {0}", c2.Id);
		}

		[TestMethod]
		public void Check_Singleton()
		{
			Singleton s1 = Singleton.getInstance();
			Singleton s2 = Singleton.getInstance();
			Assert.AreEqual(s1, s2);
		}

		[TestMethod]
		public void Check_Adapter()
		{
			Target target = new Adapter();
			target.Request();
		}

		[TestMethod]
		public void Check_Bridge()
		{
			Abstraction ab = new RefinedAbstraction();
			ab.Implementor = new SP_Bridge.ConcreteImplementorA();
			ab.Operation();
			ab.Implementor = new SP_Bridge.ConcreteImplementorB();
			ab.Operation();
		}


		[TestMethod]
		public void Check_Composite()
		{
			Composite root = new Composite("root");
			root.Add(new Leaf("Leaf A"));
			root.Add(new Leaf("Leaf B"));

			Composite comp = new Composite("Composite X");
			comp.Add(new Leaf("Leaf XA"));
			comp.Add(new Leaf("Leaf XB"));

			root.Add(comp);
			root.Display(1);

		}
	}
}
