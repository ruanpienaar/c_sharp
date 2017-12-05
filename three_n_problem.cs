using System;

namespace Application
{
	public class three_n_problem
	{
	int starting_number;
		public three_n_problem (int n)
		{
			
		}
		
		public Boolean number_modulo (int number, int dividend){
			if ((number % dividend) == 0) {
				return true;
			} else {
				return false;
			}
		}
	}
	
	public class test{
		public static void main (){
			
		}
	}
		
}