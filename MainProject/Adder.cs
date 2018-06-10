namespace Calculator
{
	public class Adder
	{
		public Logger Logger { get; set; } = new Logger();
		public float AddFloats(float a, float b)
		{
			Logger.Log("AddFloats");
			return a + b;
		}
		public int AddInts(int a, int b)
		{
			Logger.Log("AddInts");
			return a + b;
		}
	}
}
