/*
An application calls the Invoice contructor class and sets up a mock invoice.
*/

import java.util.Scanner;

public class InvoiceTest
{

	public static void main( String args[] )
	{
		Invoice invoice1 = new Invoice("1", "hammer", 20, 5.00);
		Invoice invoice2 = new Invoice("2", "screwdriver", 15, 7.50);
		Invoice invoice3 = new Invoice("3", "drill", 10, 10.00);
		Invoice invoice4 = new Invoice("4", "staplegun", 5, 20.00);
		Invoice invoice5 = new Invoice("5", "rake", 10, 5.00);
		Scanner input = new Scanner(System.in);
		int quantity;

	System.out.printf( "Part number: %s\n", invoice1.getPartNumber() );
	System.out.printf( "Description: %s\n", invoice1.getPartDescription() );
	System.out.printf( "Quantity: %d\n", invoice1.getQuantity() );
	System.out.printf( "Price: %.2f\n", invoice1.getPrice() );
	System.out.printf( "Invoice amount: %.2f\n\n", invoice1.getInvoiceAmount() );

	System.out.printf( "Part number: %s\n", invoice2.getPartNumber() );
	System.out.printf( "Description: %s\n", invoice2.getPartDescription() );
	System.out.printf( "Quantity: %d\n", invoice2.getQuantity() );
	System.out.printf( "Price: %.2f\n", invoice2.getPrice() );
	System.out.printf( "Invoice amount: %.2f\n\n", invoice2.getInvoiceAmount() );

	System.out.printf( "Part number: %s\n", invoice3.getPartNumber() );
	System.out.printf( "Description: %s\n", invoice3.getPartDescription() );
	System.out.printf( "Quantity: %d\n", invoice3.getQuantity() );
	System.out.printf( "Price: %.2f\n", invoice3.getPrice() );
	System.out.printf( "Invoice amount: %.2f\n\n", invoice3.getInvoiceAmount() );

	System.out.printf( "Part number: %s\n", invoice4.getPartNumber() );
	System.out.printf( "Description: %s\n", invoice4.getPartDescription() );
	System.out.printf( "Quantity: %d\n", invoice4.getQuantity() );
	System.out.printf( "Price: %.2f\n", invoice4.getPrice() );
	System.out.printf( "Invoice amount: %.2f\n\n", invoice4.getInvoiceAmount() );
	
	System.out.printf( "Part number: %s\n", invoice5.getPartNumber() );
	System.out.printf( "Description: %s\n", invoice5.getPartDescription() );
	System.out.printf( "Quantity: %d\n", invoice5.getQuantity() );
	System.out.printf( "Price: %.2f\n", invoice5.getPrice() );
	System.out.printf( "Invoice amount: %.2f\n", invoice5.getInvoiceAmount() );

	
}
}