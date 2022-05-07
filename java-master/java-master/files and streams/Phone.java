
/*
This program creates 8 numbers and sets three letters to each number. When the user types in a phone
number the program will create numerous combinations of letters for each number and saves it to a file
named "myfile.txt".
*/

import java.util.Scanner;
import java.io.*;

public class Phone {

	public static void dialling()
 	{
		FileOutputStream out; 
		  PrintStream ps;
		  
		 


		char number2[] = { 'A', 'B', 'C' };
		char number3[] = { 'D', 'E', 'F' };
		char number4[] = { 'G', 'H', 'I' };
		char number5[] = { 'J', 'K', 'L' };
		char number6[] = { 'M', 'N', 'O' };
		char number7[] = { 'P', 'R', 'S' };
		char number8[] = { 'T', 'U', 'V' };
		char number9[] = { 'W', 'X', 'Y', };

		char Letter0[] = { ' ',' ',' ' };
		char Letter1[] = { ' ',' ',' ' };
		char Letter2[] = { ' ',' ',' ' };
		char Letter3[] = { ' ',' ',' ' };
		char Letter4[] = { ' ',' ',' ' };
		char Letter5[] = { ' ',' ',' ' };
		char Letter6[] = { ' ',' ',' ' };
		char Letter7[] = { ' ',' ',' ' };

		Scanner scanner = new Scanner( System.in );

		Character phoneArray[] = new Character[ 7 ];

		System.out.println( "Please enter a phone number." );
		String phoneNumber = scanner.nextLine();

		try
		{
			 out = new FileOutputStream("myfile.txt");
			 ps = new PrintStream(out);

			for( int i=0; i < phoneNumber.length(); i++ )
			{
				phoneArray[i]=(new Character(phoneNumber.charAt(i)));
			}
			if (phoneArray[0].equals('2'))
				for (int j = 0; j < Letter0.length;j++)
				Letter0[j] = number2[j];
				else if (phoneArray[0].equals('3'))
				for (int j = 0; j < Letter0.length;j++)
				Letter0[j] = number3[j];
				else if (phoneArray[0].equals('4'))
				for (int j = 0; j < Letter0.length;j++)
				Letter0[j] = number4[j];
				else if (phoneArray[0].equals('5'))
				for (int j = 0; j < Letter0.length;j++)
				Letter0[j] = number5[j];
				else if (phoneArray[0].equals('6'))
				for (int j = 0; j < Letter0.length;j++)
				Letter0[j] = number6[j];
				else if (phoneArray[0].equals('7'))
				for (int j = 0; j < Letter0.length;j++)
				Letter0[j] = number7[j];
				else if (phoneArray[0].equals('8'))
				for (int j = 0; j < Letter0.length;j++)
				Letter0[j] = number8[j];
				else if (phoneArray[0].equals('9'))
				for (int j = 0; j < Letter0.length;j++)
				Letter0[j] = number9[j];

				if (phoneArray[1].equals('2'))
				for (int j = 0; j < Letter1.length;j++)
				Letter1[j] = number2[j];
				else if (phoneArray[1].equals('3'))
				for (int j = 0; j < Letter1.length;j++)
				Letter1[j] = number3[j];
				else if (phoneArray[1].equals('4'))
				for (int j = 0; j < Letter1.length;j++)
				Letter1[j] = number4[j];
				else if (phoneArray[1].equals('5'))
				for (int j = 0; j < Letter1.length;j++)
				Letter1[j] = number5[j];
				else if (phoneArray[1].equals('6'))
				for (int j = 0; j < Letter1.length;j++)
				Letter1[j] = number6[j];
				else if (phoneArray[1].equals('7'))
				for (int j = 0; j < Letter1.length;j++)
				Letter1[j] = number7[j];
				else if (phoneArray[1].equals('8'))
				for (int j = 0; j < Letter1.length;j++)
				Letter1[j] = number8[j];
				else if (phoneArray[1].equals('9'))
				for (int j = 0; j < Letter1.length;j++)
				Letter1[j] = number9[j];

				if (phoneArray[2].equals('2'))
				for (int j = 0; j < Letter2.length;j++)
				Letter2[j] = number2[j];
				else if (phoneArray[2].equals('3'))
				for (int j = 0; j < Letter2.length;j++)
				Letter2[j] = number3[j];
				else if (phoneArray[2].equals('4'))
				for (int j = 0; j < Letter2.length;j++)
				Letter2[j] = number4[j];
				else if (phoneArray[2].equals('5'))
				for (int j = 0; j < Letter2.length;j++)
				Letter2[j] = number5[j];
				else if (phoneArray[2].equals('6'))
				for (int j = 0; j < Letter2.length;j++)
				Letter2[j] = number6[j];
				else if (phoneArray[2].equals('7'))
				for (int j = 0; j < Letter2.length;j++)
				Letter2[j] = number7[j];
				else if (phoneArray[2].equals('8'))
				for (int j = 0; j < Letter2.length;j++)
				Letter2[j] = number8[j];
				else if (phoneArray[2].equals('9'))
				for (int j = 0; j < Letter2.length;j++)
				Letter2[j] = number9[j];

				if (phoneArray[3].equals('2'))
				for (int j = 0; j < Letter3.length;j++)
				Letter3[j] = number2[j];
				else if (phoneArray[3].equals('3'))
				for (int j = 0; j < Letter3.length;j++)
				Letter3[j] = number3[j];
				else if (phoneArray[3].equals('4'))
				for (int j = 0; j < Letter3.length;j++)
				Letter3[j] = number4[j];
				else if (phoneArray[3].equals('5'))
				for (int j = 0; j < Letter3.length;j++)
				Letter3[j] = number5[j];
				else if (phoneArray[3].equals('6'))
				for (int j = 0; j < Letter3.length;j++)
				Letter3[j] = number6[j];
				else if (phoneArray[3].equals('7'))
				for (int j = 0; j < Letter3.length;j++)
				Letter3[j] = number7[j];
				else if (phoneArray[3].equals('8'))
				for (int j = 0; j < Letter3.length;j++)
				Letter3[j] = number8[j];
				else if (phoneArray[3].equals('9'))
				for (int j = 0; j < Letter3.length;j++)
				Letter3[j] = number9[j];

				if (phoneArray[4].equals('2'))
				for (int j = 0; j < Letter4.length;j++)
				Letter4[j] = number2[j];
				else if (phoneArray[4].equals('3'))
				for (int j = 0; j < Letter4.length;j++)
				Letter4[j] = number3[j];
				else if (phoneArray[4].equals('4'))
				for (int j = 0; j < Letter4.length;j++)
				Letter4[j] = number4[j];
				else if (phoneArray[4].equals('5'))
				for (int j = 0; j < Letter4.length;j++)
				Letter4[j] = number5[j];
				else if (phoneArray[4].equals('6'))
				for (int j = 0; j < Letter4.length;j++)
				Letter4[j] = number6[j];
				else if (phoneArray[4].equals('7'))
				for (int j = 0; j < Letter4.length;j++)
				Letter4[j] = number7[j];
				else if (phoneArray[4].equals('8'))
				for (int j = 0; j < Letter4.length;j++)
				Letter4[j] = number8[j];
				else if (phoneArray[4].equals('9'))
				for (int j = 0; j < Letter4.length;j++)
				Letter4[j] = number9[j];

				if (phoneArray[5].equals('2'))
				for (int j = 0; j < Letter5.length;j++)
				Letter5[j] = number2[j];
				else if (phoneArray[5].equals('3'))
				for (int j = 0; j < Letter5.length;j++)
				Letter5[j] = number3[j];
				else if (phoneArray[5].equals('4'))
				for (int j = 0; j < Letter5.length;j++)
				Letter5[j] = number4[j];
				else if (phoneArray[5].equals('5'))
				for (int j = 0; j < Letter5.length;j++)
				Letter5[j] = number5[j];
				else if (phoneArray[5].equals('6'))
				for (int j = 0; j < Letter5.length;j++)
				Letter5[j] = number6[j];
				else if (phoneArray[5].equals('7'))
				for (int j = 0; j < Letter5.length;j++)
				Letter5[j] = number7[j];
				else if (phoneArray[5].equals('8'))
				for (int j = 0; j < Letter5.length;j++)
				Letter5[j] = number8[j];
				else if (phoneArray[5].equals('9'))
				for (int j = 0; j < Letter5.length;j++)
				Letter5[j] = number9[j];

				if (phoneArray[6].equals('2'))
				for (int j = 0; j < Letter6.length;j++)
				Letter6[j] = number2[j];
				else if (phoneArray[6].equals('3'))
				for (int j = 0; j < Letter6.length;j++)
				Letter6[j] = number3[j];
				else if (phoneArray[6].equals('4'))
				for (int j = 0; j < Letter6.length;j++)
				Letter6[j] = number4[j];
				else if (phoneArray[6].equals('5'))
				for (int j = 0; j < Letter6.length;j++)
				Letter6[j] = number5[j];
				else if (phoneArray[6].equals('6'))
				for (int j = 0; j < Letter6.length;j++)
				Letter6[j] = number6[j];
				else if (phoneArray[6].equals('7'))
				for (int j = 0; j < Letter6.length;j++)
				Letter6[j] = number7[j];
				else if (phoneArray[6].equals('8'))
				for (int j = 0; j < Letter6.length;j++)
				Letter6[j] = number8[j];
				else if (phoneArray[6].equals('9'))
				for (int j = 0; j < Letter6.length;j++)
				Letter6[j] = number9[j];

				for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
				for (int k = 0; k < 3; k++) {
				for (int l = 0; l < 3; l++) {
				for (int m = 0; m < 3; m++) {
				for (int n = 0; n < 3; n++) {
				for (int o = 0; o < 3; o++) {
			    ps.print(Letter0[i]);
				ps.print(" ");
				ps.print(Letter1[j]);
				ps.print(" ");
				ps.print(Letter2[k]);
				ps.print(" ");
				ps.print(Letter3[l]);
				ps.print(" ");
				ps.print(Letter4[m]);
				ps.print(" ");
				ps.print(Letter5[n]);
				ps.print(" ");
				ps.print(Letter6[o]);
				ps.println();
				}
				}
				}
				}
				}
				}
				}
				ps.close();
		}
		catch(ArrayIndexOutOfBoundsException arrayindexoutofboundsException)
		{
			System.err.println( "Phone number is too long, please try again." );
			scanner.nextLine();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		try
		{
			for (int i=0; i < phoneArray.length; i++)
			{
				if ( phoneArray[i].equals('0') )
				{
					System.out.println( "Invalid Input 0, try again." );
					scanner.nextLine();
				}
				else if ( phoneArray[i].equals('1') )
				{
					System.out.println( "Invalid Input 1, try again." );
					scanner.nextLine();
				}
			}
		}
		catch (NullPointerException nullpointerException )
		{
			System.err.println( "Phone number too short try again." );
			scanner.nextLine();
		}

		
	}
}