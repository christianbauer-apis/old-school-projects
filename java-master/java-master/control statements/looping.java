/*
a simple looping application
*/

import java.util.Scanner;

public class looping{

	public static void main( String args[])
	{
		int counter=1;

System.out.print("N\t10*N\t100*N\t1000*N\n\n");
		while (counter != 6)
		{
			System.out.printf("%d\t", counter);
			System.out.printf("%d\t", 10*counter);
			System.out.printf("%d\t", 100*counter);
			System.out.printf("%d\t\n", 1000*counter);
			counter++;
		}

	}	

}