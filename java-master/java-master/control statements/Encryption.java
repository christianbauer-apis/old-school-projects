/*
Application reads a four-digit integer entered by the user and encrypts as as follows:
add 7 to the digit and get the remainder after dividing the new value by 10.Then swaps
the first digit with the third, and swap the second digit with the fourth. 
 */
import java.util.Scanner;

public class Encryption{
	
	public static void main (String args[])
	{
	int digit;
	int digit1, digit2, digit3, digit4;
	int edigit1, edigit2, edigit3, edigit4;
	

	Scanner input = new Scanner(System.in);
	System.out.print("enter four digit code: ");
	digit = input.nextInt();
	digit1 = ((digit / 1000)+7)%10;
    	digit2 = ((digit % 1000 / 100)+7)%10;
    	digit3 = ((digit % 1000 % 100 / 10)+7)%10;  
    	digit4 = ((digit % 1000 % 100 % 10 )+7)%10;
    	edigit1 = digit3;
	edigit2 = digit4;
	edigit3 = digit1;
	edigit4 = digit2;
	System.out.printf("encrypted code is %d%d%d%d", edigit1, edigit2, edigit3, edigit4);
	
	
}
}