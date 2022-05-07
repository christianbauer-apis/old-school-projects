/*
This program implements buuble sort. The bubble sort arranges the numbers in the array from least to
greatest. The reason why bubble sort is an O(n^2) algorithm is that the algorithm has to make a
comparison with every element in the array. In this program the array has nine elements so the algorithm
has to make 81 comparisons.
*/

public class bubbleSort
{
	public static void bubbleSort(int array[])
	{
		boolean swapped = true; 

		while(swapped)
		{
			swapped = false; 

			for(int i = 0; i < array.length - 1; i++)
			{
				if(array[i] > array[i + 1])
				{
					swapped = true;
					int temp = array[i];
					array[i] = array[i + 1];
					array[i + 1] = temp;
				} 
			} 

			for(int i = 0; i < array.length; i++)
			{
				System.out.print(array[i] + "\t");
			} 
			
			System.out.println();

		} 

	} 

public static void main( String args[] )
{
int[] sort = {10, 75, 89, 16, 64, 93, 47, 56, 28};
bubbleSort(sort);

}	
}
