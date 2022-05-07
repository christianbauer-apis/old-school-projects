/*
An application that asks the user to input a number and then the program will print the inputted 
number of asterisks. 
*/

import java.util.Scanner;

public class numisasterisk
{
public static void main (String args[])
{
int counter=0;
int number;
Scanner input = new Scanner(System.in);
 
while(counter!=5){

System.out.print("\nenter a number of integers: ");
number = input.nextInt();
if (number >30){
System.out.print(" enter a number between 1 and 30\n");
} else{			
for(int i=1; i<=number; i++)
System.out.print("*"); 			
			
counter++;
}
}
}
}