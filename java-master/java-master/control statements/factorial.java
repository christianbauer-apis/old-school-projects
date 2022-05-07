/*
An application that evaluates the factorials of the integers from 1 to 5.
*/
public class factorial
{
	public static void main(String args[])
	{
		int factorial=5;
		int number=1;
		int total;
		while( factorial > 0)
		{
		for(int i=factorial; i>0; i--)
		number=number*i;
		
		System.out.printf("factorial of %d is: %d\n", factorial,number);
		factorial--;
		if (number > 1)
		number=1;	
		
	}
}
}