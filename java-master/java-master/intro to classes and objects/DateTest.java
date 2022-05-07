/*
An application that calls the constructor class and displays a date.
*/

public class DateTest
{

	public static void main(String args[])
	{
		Date date1 = new Date(12, 25, 1987);

		System.out.print("Date\t");
		date1.displayDate();
	}
}