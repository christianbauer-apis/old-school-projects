/*
An application that reads an integer and determines and prints whether it is odd or even.
*/

import java.util.Scanner;

public class OddorEven
{

	public static void main( String args[] )
	{
	Scanner input = new Scanner(System.in);

		int integer;
		int multiple;

		System.out.print("Enter first integer: \n");
		integer = input.nextInt();

		multiple = integer % 2;
		if(multiple == 0)
		System.out.print( "integer is even." );
		else
		System.out.print( "integer is odd." );
}
}