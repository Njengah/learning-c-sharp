using System;


//Creating interface class which is a completely abstract class that does not have the normal methods only abstract methods 

// Fiddle https://dotnetfiddle.net/yWQLzr 
					
public class Rectangle
{
	
	//interface
	
	interface RectInterface{
	
	  int Length(); 
	  int Width(); 
	
	}
	
	class RectDimensions:RectInterface{
	
		public int Length(){
			
			return 50; 
			
		}

		public int Width(){
			 
			return 40; 

		}
		
		
	}
	
	
	class Area : RectDimensions{
	
	  public int calcArea(){
	  
	    return  Length() * Width(); 
	  
	   }
	
	
	}
	
	//Main method 
	
	public static void Main(){
		
		//Console.WriteLine("Joe Testing Interface here :) ");
		
		//create Object 
		
		Area AreaValue = new Area(); 
		
		Console.WriteLine(AreaValue.calcArea());  
		
	}
	
	
}