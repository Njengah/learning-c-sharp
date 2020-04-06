/**
 *  C# Learning Class Inheritance, Abstract Class and Overiding Abstract Method  
 */ 

using System;
					
public class Rectangle
{	
  //Main Method 
	public static void Main(string[] args){
		
		//Console.WriteLine("Joe Testing Things Here");
		
		Area O =  new Area(); 
		
	    Console.WriteLine(O.getArea(20,30));	
	
	}
		
}

abstract class Dimensions
{

	public abstract int width(int x);
	
	public int length(int y){
		
		 return y; 
	}


}
