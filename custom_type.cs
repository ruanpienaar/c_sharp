using System;

namespace Application
{
	public class custom_type
	{
		int value;
		int scaleFactor;
		
		public custom_type(int scaleFactor) { 
			this.scaleFactor = scaleFactor;  
		}
		
		public void inc(){
			value+=scaleFactor;
		}
		
		public int count(){
			get {return value;}
		}
		
	}
}
