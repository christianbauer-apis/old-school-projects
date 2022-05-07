/*
An application that calculates the product of the odd integers from 1 to 15.
*/
public class oddmult
{
	public static void main( String args[])
	{
	int number=1;
	for(int i=1; i<=15; i+=2)
	number=number*i;
	
	System.out.printf( "product of odd is: %d", number);
	}
}