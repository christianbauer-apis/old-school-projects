/*
An application that inputs one number consisting of five digits from the user, separates the number
into its individual digits and prints the digits separated from one another by three spaces each.
*/

import java.util.Scanner;

public class fivedigits
{


	public static void main(String args[])
	{
	    Scanner input = new Scanner(System.in);
	
	    int integer;
	    int digit1, digit2, digit3, digit4, digit5;
	    System.out.print("enter an integer: ");
	    integer = input.nextInt();
		
            digit1 = integer / 10000;
            digit2 = integer % 10000 / 1000;
            digit3 = integer % 10000 % 1000 / 100;
            digit4 = integer % 10000 % 1000 % 100 / 10;
            digit5 = integer % 10000 % 1000 % 100 % 10;

            System.out.printf("%d   %d   %d   %d   %d", digit1, digit2, digit3, digit4, digit5);
	
	}
}