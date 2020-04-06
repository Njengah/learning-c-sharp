/**
 *  C# Learning Practice and Snippets 
 */ 

using System; 
 
 
 // Console Application 
 
 namespace learnCS{
	 
	 
	  class learnCS{
		  
		//Data Types  
		
		string name    = "Joe"; 
		int age        = 35; 
		double balance = 1200.35;
		//char nickname  = 'J'; 
		//bool isMale    = true; 
		
		//Display to the console 
		
		public void Display(){
			
			 //Console.WriteLine("Hello" + name ); 
			 
			Console.WriteLine("Hello " + " "+ name + " " + "your age is "+ " " + age + " " +"your bank balance is "+ " " + balance); 
		}
		
		
		//Main Method 
		 static void Main(string[] args){
			  
			 //Console.WriteLine("Hello Joe Learning C# and becoming a pro in one Year"); 
			  
			 //Lesson #1) Creating an instance you should use the namespace Example learnCS Obj with the reference 
			 //Lesson #2) You cannot call other parts of program within the static main function DIRECTLY ie properties 
			 //Lesson #3) Using Console.Key() 
			 //Lesson #4)  C# is a CASE SENSITIVE language example the main function should be Main not main 

			 learnCS Obj = new learnCS(); 
			  
			  Obj.Display(); 
			 
			  Console.ReadKey(); 
			  
		  }  
		  
	  }
	 
 }