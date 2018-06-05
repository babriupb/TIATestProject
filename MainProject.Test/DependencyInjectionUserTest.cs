using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace MainProject.Test
{
	[TestClass]
	public class DependencyInjectionUserTest
	{
		[TestMethod]
		public void TestDependencyInjection()
		{
			var sut = CreateSut();

			Assert.AreEqual("Test 2", sut.GetTest2());
		}

		private DependencyInjectionUser CreateSut()
		{
			var container = new UnityContainer();

			container.RegisterType<IInjectedInterface, InjectedClass>();
			container.RegisterType<DependencyInjectionUser>();

			return container.Resolve<DependencyInjectionUser>();
		}

	}
}
