/*
This program instantiates object Circles of class Circles and displays the eight concentric
circles on a window using the JFrame class.
*/

import javax.swing.JFrame;

public class CirclesTest{

	public static void main(String args[])
	{
		JFrame frame = new JFrame();
		frame.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );

		Circles g = new Circles();	
		frame.add( g );
		frame.setSize( 800, 600 );
		frame.setVisible( true );
	}

}