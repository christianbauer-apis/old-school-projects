/*
An application that reads two integers, determines whether the first is a multiple of the second and 
prints the result.
*/

import java.util.Scanner;

public class multiples
{

	public static void main( String args[] )
	{
	Scanner input = new Scanner(System.in);

		int integer1;
		int integer2;
		int multiple;

		System.out.print("Enter first integer:");
		integer1 = input.nextInt();

		System.out.print("\nEnter second integer:");
		integer2 = input.nextInt();

		multiple = integer1 % integer2;
		if(multiple == 0)
		System.out.print( "\ninteger1 is a multiple of integer2." );
		else
		System.out.print( "integer1 is not a multiple of integer2." );
}
}