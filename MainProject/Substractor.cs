namespace Calculator
{
	public class Substractor
	{
		public Logger Logger { get; set; } = new Logger();
		public float SubFloats(float a, float b)
		{
			Logger.Log("SubFloats");
			return a - b;
		}
		public int SubInts(int a, int b)
		{
			Logger.Log("SubInts");
			return a - b;
		}
	}
}
