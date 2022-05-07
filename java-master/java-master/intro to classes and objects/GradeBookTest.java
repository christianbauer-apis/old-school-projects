/*
An application that calls the gradebook constructor class and 
displays a coursename and instructor name.
*/

public class GradeBookTest
{
	public static void main( String args[] )
	{
		GradeBook gradeBook1 = new GradeBook( 
			"CS101 Introduction to Java Programming",
			"John Doe" );
		GradeBook gradeBook2 = new GradeBook(
			"CS102 Data Structures in Java", 
			"Jane Doe");
		
		
		System.out.printf( "gradeBook1 course name is: %s\n",
			gradeBook1.getCourseName() );
		System.out.printf( "This course is presented by: %s\n",
			gradeBook1.getInstructorName() );
		System.out.printf( "gradeBook2 course name is: %s\n",
			gradeBook2.getCourseName() );
		System.out.printf( "This course is presented by: %s\n",
			gradeBook2.getInstructorName() );


	} 

} 