using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bla;
using MainProject.Sub1.Sub2;

namespace MainProject
{
	public class Program
	{
		[MyAttribute]
		private readonly SuperCalculator myProperty;

		public static void Main(string[] args)
		{
			string test = (new Calculator()).Identifier;

			string test2 = TestClass.Wurst;

			string test3 = typeof(MySuperClass<,>).FullName;

			var nested = new NestedClass("Test");
			nested.Test = default(StringHelper);

			var class1 = new Class1();
		}
	}

	namespace Sub1
	{
		namespace Sub2
		{
			class NestedClass
			{
				public NestedClass(string test)
				{
					
				}

				public StringHelper Test { get; set; }
			}
		}
	}
}
