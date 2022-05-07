/*
An application that reads three nonzero values entered by the user and determines and prints 
whether they could represent the sides of a triangle.
*/

import java.util.Scanner;

public class triangle{

	public static void main( String args[])
	{
	int number;
	int first=0;
	int second=0;
	int third=0;
	int triangle;
	int counter=0;
	Scanner input = new Scanner(System.in);
		while( counter <= 2)
		{
	
		System.out.print( "Please enter a number: " );
		number = input.nextInt();
		
		counter++;
		 if (number > first) {  
    		third = second;
			second = first;  
    		first = number;  
 }  
 else if(number > second) {  
    third = second;
	second = number;  
 } 
	else if(number > third){
	third = number;
	}
	}
	triangle = second + third;
	if ( triangle > first)
	System.out.print( "this could be a triangle" );
	else
	System.out.print( "this is not a triangle" );

}
}