using System;

namespace Application
{
	public class example
	{
		static void Main ()
		{
			Console.WriteLine("Hello World");
			square s = new square();
			Console.WriteLine(s.area(2,4));
			for(int a = 0 ; a < 2; a++ )
			{
				Console.WriteLine("a is :"+a);
			}
			circle c = new circle();
			Console.WriteLine(c.area(10));
			triangle t = new triangle();
			Console.WriteLine(t.area(10,5));

			string str = "Ruan";
			Console.WriteLine(str.ToLower());
		}
	}

	public class square
	{
		public int area (int width, int height)
		{
			return ( width*height );
		}
	}

	public class circle{

		public double area (int radius)
		{
			return ( Math.PI * Math.Pow(Convert.ToDouble(radius),2.0) );
		}

	}

	public class triangle{
		public double area (int baselength, int height){
			return ( 0.5 * baselength * height );
		}
	}

}

