/* 
Create and manipulate an Account object.
*/

import java.util.Scanner;

public class AccountTest
{
	public static void main( String args[] )
	{
		Account account1 = new Account( 50.00 ); 
		Account account2 = new Account( -7.53 ); 

		System.out.printf( "account1 balance: $%.2f\n",
			account1.getBalance() );
		System.out.printf( "account2 balance: $%.2f\n\n",
			account2.getBalance() );

		Scanner input = new Scanner( System.in );
		double depositAmount; 

		System.out.print( "Enter deposit amount for account1: " ); 
		depositAmount = input.nextDouble(); 
		System.out.printf( "\nadding $%.2f to account1 balance\n\n",
			depositAmount );
		account1.credit( depositAmount );

		System.out.printf( "account1 balance: $%.2f\n",
			account1.getBalance() );
		System.out.printf( "account2 balance: $%.2f\n\n",
			account2.getBalance() );

		System.out.print( "Enter withdrawal amount for account1: " ); 
		depositAmount = input.nextDouble(); 
		System.out.printf( "\nwithdrawing $%.2f to account1 balance\n\n",
			depositAmount );
		account1.debit( depositAmount );

		System.out.printf( "account1 balance: $%.2f\n",
			account1.getBalance() );
		System.out.printf( "account2 balance: $%.2f\n\n",
			account2.getBalance() );

		System.out.print( "Enter deposit amount for account2: " ); 
		depositAmount = input.nextDouble(); 
		System.out.printf( "\nadding $%.2f to account2 balance\n\n",
			depositAmount );
		account2.credit( depositAmount ); 

		System.out.printf( "account1 balance: $%.2f\n",
			account1.getBalance() );
		System.out.printf( "account2 balance: $%.2f\n",
			account2.getBalance() );

		System.out.print( "Enter withdrawal amount for account2: " ); 
		depositAmount = input.nextDouble(); 
		System.out.printf( "\nwithdrawing $%.2f to account2 balance\n\n",
			depositAmount );
		account2.debit( depositAmount ); 

		System.out.printf( "account1 balance: $%.2f\n",
			account1.getBalance() );
		System.out.printf( "account2 balance: $%.2f\n",
			account2.getBalance() );

	} 

} 