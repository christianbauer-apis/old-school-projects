
// Analysis of examination results.
import java.util.Scanner; 

public class Analysis
{
	public void processExamResults()
	{
	
		Scanner input = new Scanner( System.in );

		
		int passes = 0; 
		int failures = 0; 
		int studentCounter = 1; 
		int result; 

		
		while ( studentCounter <= 10 )
		{
			
			System.out.print( "Enter result (1 = pass, 2 = fail): " );
			result = input.nextInt();

			
			if ( result == 1 ){			
				passes = passes + 1; 
				studentCounter = studentCounter + 1;  
				} 
			else
			if ( result == 2){			
				failures = failures + 1; 
				studentCounter = studentCounter + 1;
				}
			
		
		} 
		
		
		System.out.printf( "Passed: %d\nFailed: %d\n", passes, failures );

		
		if ( passes > 8 )
			System.out.println( "Raise Tuition" );
	} 

} 