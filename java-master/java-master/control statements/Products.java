import java.util.Scanner;

public class Products
{
public static void main(String args[])
{
Scanner input = new Scanner( System.in);

double product1 = 2.98;
double product2 = 4.50;
double product3 = 9.98;
double product4 = 4.49;
double product5 = 6.87;

int quantity1=0;
int quantity2=0;
int quantity3=0;
int quantity4=0;
int quantity5=0;

double total;

int product;

while( input.hasNext())
{
System.out.print("Enter the product number:");
product = input.nextInt();

switch(product)
{
case 1:
System.out.printf( "\nEnter the quantity of items sold:", quantity1);
product1=product1*quantity1;
break;

case 2:
System.out.printf( "\nEnter the quantity of items sold:", quantity2);
product2=product2*quantity2;
break;

case 3:
System.out.printf( "\nEnter the quantity of items sold:", quantity3);
product3=product3*quantity3;
break;

case 4:
System.out.printf( "\nEnter the quantity of items sold:", quantity4);
product4=product4*quantity4;
break;

default:
System.out.printf( "\nEnter the quantity of items sold:", quantity5);
product5=product5*quantity5;
break;
}
}
System.out.printf("%s%f\n%s%f\n%s%f\n%s%f\n%s%f\n",
"product1 sales: ", product1, 
"product2 sales: ", product2, 
"product3 sales: ", product3, 
"product4 sales: ", product4, 
"product5 sales: ", product5);

}
}