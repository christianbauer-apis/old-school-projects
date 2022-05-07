/*
 An application that has the user input 3 numbers in the command line to determine 
 the size of the array. If there are no numbers inputted then the size will be 10.
 In eclipse, to get the command line, go to run configurations, click on the arguments
 tab, and in the program arguments window put in your three numbers. (i.e. 1 2 3)    
 */


import java.util.Scanner;

public class InitArray 
{
	public static void main(String args[])
	{
		Scanner input = new Scanner(System.in);
		int array[];
		int number;
		
		if (args.length !=3){
			array = new int[10];
			System.out.printf("%s%8s\n", "Index", "Value");
			
			for(int counter=0; counter < array.length; counter++)
					System.out.printf( "%5d%8d\n", counter, array[ counter ]);
		}
		else
		{
		int arrayLength = Integer.parseInt( args[0]);
		array = new int[arrayLength];
		int initialValue = Integer.parseInt( args[1]);
		int increment = Integer.parseInt( args[2]);
		System.out.printf("%s%8s\n", "Index", "Value");
		
		for(int counter=0; counter < array.length; counter++)
				System.out.printf( "%5d%8d\n", counter, array[ counter ]);
		}
		
	}
}
