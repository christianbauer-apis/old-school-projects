/*
An application that calculates the squares and cubes of the numbers from 0 to 10 and 
prints the resulting values in table format.
*/


public class squaresAndCubes
{

public static void main(String args[])
{
	int square0;
	int square1;
	int square2;
	int square3;
	int square4;
	int square5;
	int square6;
	int square7;
	int square8;
	int square9;
	int square10;
	int cube0;
	int cube1;
	int cube2;
	int cube3;
	int cube4;
	int cube5;
	int cube6;
	int cube7;
	int cube8;
	int cube9;
	int cube10;
		
	square0 = 0 * 0;
	square1 = 1 * 1;
	square2 = 2*2;
	square3 = 3*3;
	square4 = 4*4;
	square5 = 5*5;
	square6 = 6*6;
	square7 = 7*7;
	square8 = 8*8;
	square9 = 9*9;
	square10 = 10*10;
	cube0 = 0*0*0;
	cube1 = 1*1*1;
	cube2 = 2*2*2;
	cube3 = 3*3*3;
	cube4 = 4*4*4;
	cube5 = 5*5*5;
	cube6 = 6*6*6;
	cube7 = 7*7*7;
	cube8 = 8*8*8;
	cube9 = 9*9*9;
	cube10 = 10*10*10;


	System.out.print("number   square  cube\n");
	
	System.out.printf(" 0\t %d\t %d\n 1\t %d\t %d\n 2\t %d\t %d\n 3\t %d\t %d\n 4\t %d\t %d\n 5\t %d\t %d\n 6\t %d\t %d\n 7\t %d\t %d\n 8\t %d\t %d\n 9\t %d\t %d\n 10\t %d\t %d",
	square0, cube0, square1, cube1, square2, cube2, square3, cube3, square4, cube4, square5, cube5,
	square6, cube6, square7, cube7, square8, cube8, square9, cube9, square10, cube10);
}
}