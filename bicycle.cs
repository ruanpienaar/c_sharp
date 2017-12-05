using System;

namespace Application
{

	public class Main{
		public Main()
		{
			bicycle b = new bicycle();
			b.print_state();
			string s = "New String";
			
		}
	}

	public class bicycle
	{
		public void print_state(){
			Console.WriteLine("Getting state...");
		}
	}
}

