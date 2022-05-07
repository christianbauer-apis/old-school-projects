/*
This program creates a linked list and sets up several methods to use. The insertAtFront and insertAtBack
methods lets the user insert an item either in the front or the back. The reverse method reverses the list
that will be created. 
*/
class ListNode
{

	Object data;
	ListNode nextNode;

	ListNode( Object object )
	{
		this( object, null );
	}

	ListNode( Object object, ListNode node )
	{
		data = object;
		nextNode = node;
	}

	Object getObject()
	{
		return data;
	}

	ListNode getNext()
	{
		return nextNode;
	}
}

public class List
{
	private ListNode firstNode;
	private ListNode lastNode;
	private String name;

	public List()
	{
		this( "list" );
	}

	public List( String listName )
	{
		name = listName;
		firstNode = lastNode = null;
	}

	public void insertAtFront( Object insertItem )
	{
		if ( isEmpty() )
			firstNode = lastNode = new ListNode( insertItem );
		else
			firstNode = new ListNode( insertItem, firstNode );
	}

	public void insertAtBack( Object insertItem )
	{
		if ( isEmpty() )
			firstNode = lastNode = new ListNode( insertItem );
		else
			lastNode = lastNode.nextNode = new ListNode( insertItem );
	}

	public boolean isEmpty()
	{
		return firstNode == null;
	}

	public void reverse() 
	{
		ListNode current = firstNode;
		if (current == null) {
		return;
		}
		if (current.nextNode == null) 
		{
		return;
		}
		ListNode temp = null;
		while (current != null)
 		{
 		ListNode nextNode = current.nextNode;
 		current.nextNode = temp;
 		temp = current;
 		current = nextNode;
 		}
 		firstNode = temp;
 		}
		
		
	public void print()
	{
		if ( isEmpty() )
		{
			System.out.printf( "Empty %s\n", name );
			return;
		}

		System.out.printf( "The %s is: ", name );
		ListNode current = firstNode;

		while ( current != null )
		{
			System.out.printf( "%s ", current.data );
			current = current.nextNode;
		}

		System.out.println( "\n" );
	}
}

