/*
An application that reads three nonzero integers and determines and prints whether they could
represent the sides of a right triangle.
*/

import java.util.Scanner;

public class rightTriangle{

	public static void main( String args[])
	{
	int number;
	int first=0;
	int firstsq;
	int second=0;
	int secondsq;
	int third=0;
	int thirdsq;
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
	firstsq = first * first;
	secondsq = second * second;
	thirdsq = third * third;
	triangle = thirdsq + secondsq;
	if ( triangle == firstsq)
	System.out.print( "this could be a right triangle" );

}
}