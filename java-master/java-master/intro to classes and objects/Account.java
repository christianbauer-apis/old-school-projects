/*
A constructor class that checks the balance of an account and withdraws money with the debit method.

*/

public class Account
{
	private double balance; 

	public Account( double initialBalance )
	{
		if ( initialBalance > 0.0 )
			balance = initialBalance;
	} 

	public void credit( double amount )
	{
		balance = balance + amount; 
	} 

	public void debit( double amount )
	{
		balance = balance - amount;
		if (balance < 0.0)
		System.out.print("Debit amount exceeded account balance.");
	}	

	public double getBalance()
	{
		return balance; 
	} 

} 