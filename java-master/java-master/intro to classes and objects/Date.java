/*
A construtor class that sets up a date for month, day and year and displays mm/dd/yyyy.
*/

public class Date
{
	int month;
	int day;
	int year;

	public Date(int m, int d, int y)
	{
		setMonth(m);
		setDay(d);
		setYear(y);
	}

	public void setMonth(int m)
	{
		month = m;
	}

	public int getMonth()
	{
		return month;
	}

	public void setDay(int d)
	{
		day = d;
	}

	public int getDay()
	{
		return day;
	}

	public void setYear(int y)
	{
		year = y;
	}

	public int getYear()
	{
		return year;
	}

	public void displayDate()
	{
		System.out.printf("%s/%s/%s", getMonth(), getDay(), getYear());
	}
	}