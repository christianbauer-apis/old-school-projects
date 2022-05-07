/*
An application that finds the largest of 10 integers.
*/

import java.util.Scanner;

public class sales
{

	public static void main (String args[])
	{
	int number;
	int largest=0;
	int counter=0;

	Scanner input = new Scanner(System.in);

	while( counter <= 9)
		{
		System.out.print( "Please enter number of sales: " );
		number = input.nextInt();
		counter++;
		if (number>largest)
		largest = number;
		}
		System.out.printf( "largest number is: %d", largest);

	}
}
