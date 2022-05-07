/*
An application that inputs three integers from the user and displays the sum, average, product, smallest
and largest of the numbers.
*/

import java.util.Scanner;

public class Average
{
	public static void main(String args[])
	{
		Scanner input = new Scanner(System.in);
		
		int integer1;
		int integer2;
		int integer3;
		int sum;
		int product;
		int average;
		int minimuminteger;
		int maximuminteger;

		System.out.print("Enter first integer:");
		integer1 = input.nextInt();

		System.out.print("Enter second integer:");
		integer2 = input.nextInt();

		System.out.print("Enter third integer:");
		integer3 = input.nextInt();

		sum = integer1 + integer2 + integer3;
		average = (integer1 + integer2 + integer3) / 3;
		product = integer1 * integer2 * integer3;
		minimuminteger = integer1;

		if(integer2 < minimuminteger)
		minimuminteger = integer2;
		
		if(integer3 < minimuminteger)
		minimuminteger = integer3;

		maximuminteger = integer1;

		if(integer2 > maximuminteger)
		maximuminteger = integer2;

		if(integer3 > maximuminteger)
		maximuminteger = integer3;
		
		System.out.printf("%d is the maximum integer\n", maximuminteger);
		System.out.printf("%d is the minimum integer\n", minimuminteger);
		System.out.printf("%d is the average\n", average);
		System.out.printf("%d is the product\n", product);
	}
}