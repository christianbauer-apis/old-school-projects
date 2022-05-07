/*
An application that asks the user to input a number for each item up to four items. Then the program 
calculates the earnings from the sales and the commission made.
*/

import java.util.Scanner;

public class Commission{

public static void main(String args[]){

double total;
double earnings;
double item1;
double item2;
double item3;
double item4;
double cost1;
double cost2;
double cost3;
double cost4;
Scanner input = new Scanner(System.in);

System.out.print("please enter number of items for first item: ");
item1=input.nextInt();
cost1=item1*239.99;

System.out.print("\nplease enter number of items for second item: ");
item2=input.nextInt();
cost2=item2*129.75;

System.out.print("\nplease enter number of items for third item: ");
item3=input.nextInt();
cost3=item3*99.95;

System.out.print("\nplease enter number of items for fourth item: ");
item4=input.nextInt();
cost4=item4*350.89;

total=cost1+cost2+cost3+cost4;
System.out.printf( "\ntotal earned is :$%.2f", total); 

earnings=(total*.09)+200;
System.out.printf( "\ntotal saleperson earnings: $%.2f", earnings); 


}





}