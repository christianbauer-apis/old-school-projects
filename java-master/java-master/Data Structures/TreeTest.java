// Exercise 17.23
// TreeTest.java
// Program performs a binary tree search.
import javax.swing.tree.TreeNode;
import com.deitel.jhtp3.ch22.Tree; 
import com.deitel.jhtp3.ch22.TreeNode;
public class TreeTest
 {
   public static void main( String args[] )
   {
      TreeTest tree = new TreeTest();
      int intVal;
      System.out.println( "Inserting the following values: " );
      for ( int i = 1; i <= 10; i++ )
 {
         intVal = ( int ) ( Math.random() * 100 );
         System.out.print( intVal + " " );
         tree.insertNode( new Integer( intVal ) );
      }
      int num = ( int ) ( Math.random() * 100 );
      TreeNode myNode = tree.binarySearch( new Integer( num ) );
            if ( myNode == null )
         System.out.println( "\n" + num + " is not in the tree." );
      else
         System.out.println( "\n" + num + " found in the tree." );
   }


 //Class Tree definition public class Tree2 extends Tree 

   public TreeNode binarySearch( Integer v )
 {
 return search( root, v );
 }
   private TreeNode search( TreeNode rootNode, Integer value )
   {
      if ( rootNode == null )
         return null;
      if ( value.intValue() == ( ( Integer ) rootNode.getData() ).intValue() )
          return rootNode;
      else if ( value.intValue() < ( ( Integer ) rootNode.getData() ).intValue() )
         return search(  rootNode.getLeft(), value );
      else   //  val > rootNode.data
          return search(  rootNode.getRight(), value );
   }
}

