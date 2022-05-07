/*
An application that reads five integers, determines and prints the largest and smallest integers
in the group.
*/

import java.util.Scanner;

public class fifthtime
{
	public static void main(String args[])
	{
		Scanner input = new Scanner(System.in);
		
		int integer1;
		int integer2;
		int integer3;
		int integer4;
		int integer5;
		int minimuminteger;
		int maximuminteger;

		System.out.print("Enter first integer:");
		integer1 = input.nextInt();

		System.out.print("Enter second integer:");
		integer2 = input.nextInt();

		System.out.print("Enter third integer:");
		integer3 = input.nextInt();

		System.out.print("Enter fourth integer:");
		integer4 = input.nextInt();

		System.out.print("Enter fifth integer:");
		integer5 = input.nextInt();

		minimuminteger = integer1;

		if(integer2 < minimuminteger)
		minimuminteger = integer2;
		
		if(integer3 < minimuminteger)
		minimuminteger = integer3;

		if(integer4 < minimuminteger)
		minimuminteger = integer4;

		if(integer5 < minimuminteger)
		minimuminteger = integer5;

		maximuminteger = integer1;

		if(integer2 > maximuminteger)
		maximuminteger = integer2;

		if(integer3 > maximuminteger)
		maximuminteger = integer3;

		if(integer4 > maximuminteger)
		maximuminteger = integer4;
		
		if(integer5 > maximuminteger)
		maximuminteger = integer5;

		System.out.printf("%d is the maximum integer\n", maximuminteger);
		System.out.printf("%d is the minimum integer\n", minimuminteger);

	}
}