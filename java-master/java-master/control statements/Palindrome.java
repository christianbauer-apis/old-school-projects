/*
An application that reads a five-digit integer and determines whether it is a palindrome. It displays
an error message if it is not a palindrome.
*/

import java.util.Scanner;

public class Palindrome 
{

      	public static void main(String args[])
      	{

      		Scanner in = new Scanner(System.in);
  
      		String t="";
  
      		System.out.println("Enter number of length 5");
 
      		if(CS.hasNext())
 
      			t =t+in.next();
  
      		if(t.length()!=5)
 
      			System.out.println("you have entered wrong number again");
 
   			if(t.charAt(0)==t.charAt(4) && t.charAt(1)==t.charAt(3))

  			    System.out.println(""+t+" is Palindrome");

      		else

      			System.out.println(t+" is not Palindrome");

       	}

      }
