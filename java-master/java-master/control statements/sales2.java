/*
An application that find the two largest values of 10 integers entered.
*/

import java.util.Scanner;

public class sales2
{

	public static void main (String args[])
	{
	int number;
	int largest=0;
	int secondLargest=0;
	int counter=0;

	Scanner input = new Scanner(System.in);

	while( counter <= 9)
		{
	
		System.out.print( "Please enter number of sales: " );
		number = input.nextInt();
		counter++;
		 if (number > largest) {  
    		secondLargest = largest;  
    		largest = number;  
 }  
 else if(number > secondLargest) {  
    secondLargest = number;  
 } 
							
		}
		
		System.out.printf( "largest number is: %d\n", largest);
		System.out.printf( "second largest number is: %d", secondLargest);
	}
}
