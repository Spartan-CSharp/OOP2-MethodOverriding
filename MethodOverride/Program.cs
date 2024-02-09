using System;

namespace MethodOverride
{
	internal class Program
	{
		private static void Main()
		{
			PersonModel person = new PersonModel
			{
				FirstName = "Tim",
				LastName = "Corey"
			};

			Console.WriteLine(person);

			_ = Console.ReadLine();
		}
	}
}
