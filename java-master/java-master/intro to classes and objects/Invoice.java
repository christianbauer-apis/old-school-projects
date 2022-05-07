/*
A constructor class that setups the set and get methods for an invoice.
*/

public class Invoice
{
	private String partNumber;
	private String partDescription;
	private int Quantity;
	private double Price;

	public Invoice(String number, String description, int quantity, double price )
	{
		partNumber = number;
		partDescription = description;
		Quantity = quantity;
		Price = price;
	}

	public void setPartNumber( String number )
	{
		partNumber = number;
	}

	public String getPartNumber()
	{
		return partNumber;
	}

	public void setPartDescription( String description )
	{
		partDescription = description;
	}

	public String getPartDescription()
	{
		return partDescription;
	}

	public void setQuantity( int quantity )
	{
		Quantity = quantity;
	}

	public int getQuantity()
	{
		return Quantity;
	}

	public void setPrice( double price )
	{
		Price = price;
	}

	public double getPrice()
	{
		return Price;
	}

	public double getInvoiceAmount()
	{
		Price = Quantity * Price;
		
		if(Quantity < 0)
		Quantity = 0;
		
		if(Price < 0.0)
		Price = 0.0;
		return Price;
	}
}