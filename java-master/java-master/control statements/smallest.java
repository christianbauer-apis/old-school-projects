/*
An application that finds the smallest of several integers.
*/

import java.util.Scanner;

public class smallest{

	public static void main(String args[]){
		int number;
		int smallest;
		int smallestnum=0;
		int counter=0;
		Scanner input = new Scanner(System.in);


			System.out.print( "enter a number of integers: ");
			number = input.nextInt();

			while (counter != number)
			{
			System.out.print( "enter a number: ");
			smallest = input.nextInt();
			counter++;

			if(smallestnum == 0)
			smallestnum = smallest;

			if( smallest < smallestnum)
			smallestnum = smallest;
			
			}
		System.out.printf("\n%d is the smallest number.", smallestnum);

	}
}