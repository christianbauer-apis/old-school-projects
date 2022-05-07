/*
This program throws and catches an exception and then rethrows the exception. Then the stack trace
prints the exception.
*/

public class exception 
{

   public static void main( String args[] )  
   {

      try 
	  {
         someMethod();
      }

      catch( Exception exception ) 
	  {
          System.err.println( exception.getMessage() + "\n" );
          exception.printStackTrace();

      }
   }

   public static void someMethod() throws Exception   {

      try {
         someMethod2();
      }

      catch( Exception exception2 ) {
         throw exception2;
      }
   }

   public static void someMethod2() throws Exception   {
      throw new Exception( "Exception thrown in someMethod2" );
   }
}
