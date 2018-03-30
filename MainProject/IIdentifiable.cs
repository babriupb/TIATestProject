namespace MainProject
{
	public interface IIdentifiable
	{
		[MyAttribute]
		string Identifier { get; }
	}
}