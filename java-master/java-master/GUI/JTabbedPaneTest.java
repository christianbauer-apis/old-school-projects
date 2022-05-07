/*
This program creates a JFrame to show the five different tabs.
*/

import javax.swing.JFrame;

public class JTabbedPaneTest
{
	public static void main ( String args[] )
	{
		JTabbedPaneFrame tabbedPaneFrame = new JTabbedPaneFrame();
		tabbedPaneFrame.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
		tabbedPaneFrame.setSize( 500, 500 );
		tabbedPaneFrame.setVisible( true );
	}
}