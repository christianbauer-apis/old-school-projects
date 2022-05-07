/*
The program instantiates a new list. The list creates 10 characters and inserts each one in front of the
prior to the last. The program calls the reverse method and reverses the list that was created. Finally
the program prints the reversed list.
*/

public class ListTest
{
	public static void main( String args[] )
	{
		List list = new List();

		list.insertAtFront("m");
		list.insertAtFront("n");
		list.insertAtFront("b");
		list.insertAtFront("v");
		list.insertAtFront("y");
		list.insertAtFront("t");
		list.insertAtFront("r");
		list.insertAtFront("e");
		list.insertAtFront("w");
		list.insertAtFront("q");
		list.print();
		list.reverse();				
		list.print();
		
	}
}