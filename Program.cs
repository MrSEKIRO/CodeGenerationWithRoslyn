namespace CodeGenerationWithRoslyn
{
	partial class Program
	{
		static void Main(string[] args)
		{
			HelloFrom("Compiler Class");
		}

		static partial void HelloFrom(string name);
	}
}