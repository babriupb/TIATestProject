﻿using System.Collections.Generic;

namespace MainProject
{
	public class Manager
	{
		public Manager()
		{
			var wurst = new Program();
			var test = new List<List<TestClass>>();
		}

		[MyAttribute]
		public StringHelper MyTest(Calculator calculator)
		{
			var x = new SuperCalculator();

			return null;
		}

		public void DoGeneric<T>(T test) where T : IIdentifiable
		{
			
		}
	}
}