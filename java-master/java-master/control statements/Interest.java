/*
An application that calculates compund-interest.
*/
public class Interest{

public static void main( String args[]){
double amount;
double principal= 1000.0;


System.out.printf( "%s%20s%20s\n", "Year", "Amount on deposit", "Rate" );
for(double rate = 0.05; rate<=.1; rate=rate+.01){
for( int year = 1; year <= 10; year++ )
{
	amount= principal* Math.pow( 1.0 + rate, year );

	System.out.printf( "%4d%, 20.2f %20.2f\n", year, amount, rate );
	}
}

}
}