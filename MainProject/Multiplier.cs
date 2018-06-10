namespace Calculator
{
	public class Multiplier
	{
		public Logger Logger { get; set; } = new Logger();
		public float MultiplyFloats(float a, float b)
		{
			Logger.Log("MultiplyFloats");
			return a * b;
		}
		public int MultiplyInts(int a, int b)
		{
			Logger.Log("MultiplyInts");
			return a * b;
		}
	}
}
