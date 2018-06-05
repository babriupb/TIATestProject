namespace MainProject
{
	public class DependencyInjectionUser
	{
		private readonly IInjectedInterface _injected;

		public DependencyInjectionUser(IInjectedInterface injected)
		{
			_injected = injected;
		}

		public string GetTest2()
		{
			return _injected.GetTest() + " 2";
		}
	}
}