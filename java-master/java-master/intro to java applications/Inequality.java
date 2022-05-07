/*
An application that asks the user to enter two integers, obtains them from the user and
displays a message if the numbers are equal, larger, or smaller.
*/


import java.util.Scanner;

public class Inequality
{
	
	public static void main( String args[] )
	{
	
		Scanner input = new Scanner( System.in );
		int integer1;
		int integer2;

		System.out.print( "Enter first integer: " );
		integer1 = input.nextInt();

		System.out.print( "Enter second integer: " );
		integer2 = input.nextInt();

		if ( integer1 == integer2 )
			System.out.printf( "These numbers are equal.\n", integer1, integer2 );

		if ( integer1 != integer2 )
			System.out.printf( "These numbers are not equal.\n", integer1, integer2 );

		if ( integer1 < integer2 )
			System.out.printf( "%d is smaller\n", integer1 );

		if ( integer1 > integer2 )
			System.out.printf( "%d is larger\n", integer1 );

		if ( integer1 <= integer2 )
			System.out.printf( "%d is smaller or equal\n", integer1 );

		if ( integer1 >= integer2 )
			System.out.printf( "%d is larger or equal\n", integer1 );

		if ( integer2 < integer1 )
			System.out.printf( "%d is smaller\n", integer2 );

		if ( integer2 > integer1 )
			System.out.printf( "%d is larger\n", integer2 );
	}
}