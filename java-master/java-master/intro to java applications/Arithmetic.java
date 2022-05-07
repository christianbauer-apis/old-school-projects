/*
The application asks the user to enter two integers, obtains them from the user and prints
their sum, product, difference and quotient.
*/

import java.util.Scanner;
public class Arithmetic
{
	
	public static void main ( String args[] )
	{
		Scanner input = new Scanner ( System.in );
		
		int integer1;
		int integer2;
		int sum;
		int product;
		int difference;
		int quotient;

		System.out.print( "Enter first integer: " );
		integer1 = input.nextInt();

		System.out.print( "Enter second integer: " );
		integer2 = input.nextInt();

		sum = integer1 + integer2;
		product = integer1 * integer2;
		difference = integer1 - integer2;
		quotient = integer1 / integer2;

		System.out.printf( "Sum is %d\n", sum );
		System.out.printf( "Product is %d\n", product );
		System.out.printf( "Difference is %d\n", difference );
		System.out.printf( "Quotient is %d\n", quotient );
	}
}