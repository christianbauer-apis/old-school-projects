/*
An application that inputs five numbers and determines and prints the number of negative
numbers input and the number of zeros input.
*/

import java.util.Scanner;

public class Counting
{
	public static void main(String args[])
	{
		Scanner input = new Scanner(System.in);

		int integer1;
		int integer2;
		int integer3;
		int integer4;
		int integer5;
		int negative = 0;
		int positive = 0;
		int zero = 0;
	

		System.out.print("Enter first integer: ");
		integer1 = input.nextInt();
		
		System.out.print("Enter second integer: ");
		integer2 = input.nextInt();

		System.out.print("Enter third integer: ");
		integer3 = input.nextInt();

		System.out.print("Enter fourth integer: ");
		integer4 = input.nextInt();

		System.out.print("Enter fifth integer: ");
		integer5 = input.nextInt();

		if(integer1 < 0)
		negative++;
		
		if(integer2 < 0)
		negative++;
		
		if(integer3 < 0)
		negative++;
		
		if(integer4 < 0)
		negative++;
		
		if(integer5 < 0)
		negative++;
		
		if(integer1 > 0)
		positive++;
		
		if(integer2 > 0)
		positive++;
		
		if(integer3 > 0)
		positive++;
		
		if(integer4 > 0)
		positive++;
		
		if(integer5 > 0)
		positive++;
		
		if(integer1 ==0)
		zero++;
		
		if(integer2 ==0)
		zero++;
		
		if(integer3 ==0)
		zero++;
		
		if(integer4 ==0)
		zero++;
		
		if(integer5 ==0)
		zero++;

		System.out.printf("number of positive: %d\n number of negative: %d\n number of zero: %d", positive,
		negative, zero);
	}
}