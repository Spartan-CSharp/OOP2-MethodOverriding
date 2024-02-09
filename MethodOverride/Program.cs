using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
	internal class Program
	{
		static void Main(string[] args)
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
