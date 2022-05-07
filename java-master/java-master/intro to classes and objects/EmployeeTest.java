/*
An application that calls the employee constructor class and creates a mock employee salary.
*/

public class EmployeeTest
{
	public static void main(String args[])
	{
		Employee employee1 = new Employee("Al", "Allen", 2500.0);
		Employee employee2 = new Employee("Zoe", "Zigler", 5000.0);
		
		System.out.println("Employee List--Before Raise in Salary\n");
		System.out.printf("%s  %24s  %24s\n", "Name", "MonthlySalary", "AnnualSalary");
		System.out.printf("%s  %20.2f  %24.2f\n", employee1.getFullName(), employee1.getMonthlySalary(),
		employee1.getAnnualSalary());
		System.out.printf("%s %19.2f %25.2f\n", employee2.getFullName(), employee2.getMonthlySalary(),
		employee2.getAnnualSalary());
		
		employee1.setMonthlySalary(employee1.getMonthlySalary() * 1.1);
		employee2.setMonthlySalary(employee2.getMonthlySalary() * 1.1);
		System.out.println("\nEmployee List--After Raise in Salary of 10.0%\n");
		System.out.printf("%s  %24s  %24s\n", "Name", "MonthlySalary", "AnnualSalary");
		System.out.printf("%s  %20.2f  %24.2f\n", employee1.getFullName(), employee1.getMonthlySalary(),
		employee1.getAnnualSalary());
		System.out.printf("%s %19.2f %25.2f\n", employee2.getFullName(), employee2.getMonthlySalary(),
		employee2.getAnnualSalary());


		}
		}