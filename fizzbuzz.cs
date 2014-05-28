using System;

namespace Application
{
	public class fizzbuzz
	{
		public fizzbuzz ()
		{
			for(int a = 1; a < 100; a++){
				Console.WriteLine(fizz_or_buzz(a));
			}
		}

		public string fizz_or_buzz (int number)
		{
			string fizz_or_buzz_string;
			if ( (number_modulo(number, 3)) && (number_modulo(number, 5)) ) {
				fizz_or_buzz_string = "FizzBuzz";
			} else if (number_modulo(number, 3)) {
				fizz_or_buzz_string = "Fizz";
			} else if (number_modulo(number, 5)) {
				fizz_or_buzz_string = "Buzz";
			} else {
				fizz_or_buzz_string = number.ToString();
			}
			return fizz_or_buzz_string+"\n";
		}
		
		public Boolean number_modulo (int number, int dividend){
			if ((number % dividend) == 0) {
				return true;
			} else {
				return false;
			}
		}
		
	}
	
	public class test {
		public static void Main(){
			fizzbuzz f = new fizzbuzz();
		}
		
	}
	
}

