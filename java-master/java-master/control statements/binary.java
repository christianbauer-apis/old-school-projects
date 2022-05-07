/*
An application that reads a five-digit bit and converts it into a decimal number.
*/

import java.util.Scanner;

public class binary{

	public static void main(String args[])
	{
	Scanner input = new Scanner(System.in);
	
	int binary;
	int bit1, bit2, bit3, bit4, bit5;
	int bits;

	System.out.print("enter five digit bit: ");
	binary = input.nextInt();
	bit1 = (binary / 10000)*16;
    bit2 = (binary % 10000 / 1000)*8;
    bit3 = (binary % 10000 % 1000 / 100)*4;
    bit4 = (binary % 10000 % 1000 % 100 / 10)*2;
    bit5 = (binary % 10000 % 1000 % 100 % 10)*1;
	bits=bit1+bit2+bit3+bit4+bit5;
	System.out.printf("\n%d\n", bits);
	
	}

}