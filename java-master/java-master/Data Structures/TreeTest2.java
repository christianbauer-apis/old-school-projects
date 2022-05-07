// Exercise 19.23 Solution: Tree2Test.java
// Program performs a binary tree search.

// Java core packages
import java.util.*;

// Deitel packages
import com.deitel.jhtp4.ch19.TreeNode;

public class TreeTest2 {

   // execute application
   public static void main( String args[] )
   {
      TreeTest tree = new TreeTest();
      int number;

      System.out.println(
         "Inserting the following values: " );

      // create Objects to store in tree
      for ( int i = 1; i <= 10; i++ ) {
         number = ( int ) ( Math.random() * 100 );
         System.out.print( number + " " );
         tree.insertNode( new Integer( number ) );
      }

      // create Object to search for in tree
      int searchNumber = ( int ) ( Math.random() * 100 );

      // search
      TreeNode myNode =
         tree.binaryTreeSearch( new Integer( searchNumber ) );

      // Object found in tree
      if ( myNode == null )
         System.out.println(
            "\n" + searchNumber + " is not in the tree." );

      // Object not in tree
      else
         System.out.println(
            "\n" + searchNumber + " found in the tree." );
   }

}  // end Tree2Test

