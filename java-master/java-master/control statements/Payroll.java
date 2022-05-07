/*
An application that detemines the gross pay for each of three employees.
*/

import java.util.Scanner;

public class Payroll
{
	public static void main ( String args[])
	{
	
		int employeeCount=1;
		int employeeCountLimit=3;
		String programOutput;
		System.out.print("Program input: ");
		programOutput="\nProgram output:\n\t#\tGross";
		while (employeeCount <= employeeCountLimit)
		{
			programOutput += calculateEarnings(employeeCount);
			employeeCount++;
		}
		System.out.printf(programOutput);

	}

private static String calculateEarnings(int employeeCount)
{
	double grossPay;
	int hoursWorked;
	double hourlyPayRate;
	Scanner input = new Scanner(System.in);
	System.out.printf("\nenter employee %d: \n", employeeCount);
	
	
	
	System.out.print("Hours worked?");
	hoursWorked = input.nextInt();

	System.out.print("Hourly pay rate?");
	hourlyPayRate = input.nextDouble();

	if (hoursWorked <= 40)
		grossPay = (hoursWorked * hourlyPayRate);
	else
		grossPay = (40.0*hourlyPayRate) + (hoursWorked-40)*(hourlyPayRate*1.5);

	return "\n\t" + employeeCount + "\t$" + grossPay;



	}	
}