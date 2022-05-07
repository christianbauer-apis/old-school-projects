/*
A constructor class that creates the setup for employee's full name and monthly and annual salary. 
*/
public class Employee
{
	String firstName;
	String lastName;
	double monthlySalary;

	public Employee(String first, String last, double salary)
	{
		setFirstName(first);
		setLastName(last);
		setMonthlySalary(salary);
	}

	public void setFirstName(String first)
	{
		firstName = first;
	}

	public String getFirstName()
	{
		return firstName;
	}
			
	public void setLastName(String last)
	{
		lastName = last;
	}

	public String getLastName()
	{
		return lastName;
	}
	
	public String getFullName()
	{
		return String.format("%s %s", firstName, lastName);
	}

	public void setMonthlySalary(double salary)
	{
		if(salary >= 0)
		monthlySalary = salary;
		else
		monthlySalary = 0;
	}

	public double getMonthlySalary()
	{
		return monthlySalary;
	}

	public double getAnnualSalary()
	{
		return getMonthlySalary()*12.0;
	}
}