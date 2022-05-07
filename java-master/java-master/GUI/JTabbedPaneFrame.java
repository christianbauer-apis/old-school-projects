/*
This program creates five different tabs.
*/


import java.awt.BorderLayout;
import java.awt.Color;
import javax.swing.JFrame;
import javax.swing.JTabbedPane;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.SwingConstants;


public class JTabbedPaneFrame extends JFrame
{

	public JTabbedPaneFrame()
	{
		super( " five panels " );

		JTabbedPane tabbedPane = new JTabbedPane();

		JLabel label1 = new JLabel( "panel one", SwingConstants.CENTER );
		JPanel panel1 = new JPanel();
		panel1.add( label1 );
		tabbedPane.addTab( "Tab One", null, panel1, "First Panel" );

		JLabel label2 = new JLabel( "panel two", SwingConstants.CENTER );
		JPanel panel2 = new JPanel();
		panel2.setBackground( Color.YELLOW );
		panel2.add( label2 );
		tabbedPane.addTab( "Tab Two", null, panel2, "Second Panel" );

		JLabel label3 = new JLabel( "panel three" );
		JPanel panel3 = new JPanel();
		panel3.setLayout( new BorderLayout() );
		panel3.add( new JButton( "North" ), BorderLayout.NORTH );
		panel3.add( new JButton( "West" ), BorderLayout.WEST );
		panel3.add( new JButton( "East" ), BorderLayout.EAST );
		panel3.add( new JButton( "South" ), BorderLayout.SOUTH );
		panel3.add( label3, BorderLayout.CENTER );
		tabbedPane.addTab( "Tab Three", null, panel3, "Third Panel" );

		JPanel panel4 = new JPanel();
		panel4.add( new JTextField ( "panel four", 20 ) );
		tabbedPane.addTab( "Tab Four", null, panel4, "Fourth Panel" );

		JPanel panel5 = new JPanel();
		panel5.add( new JTextArea ( "panel five", 10, 20 ) );
		tabbedPane.addTab( "Tab Five", null, panel5, "Fifth Panel" );

		add( tabbedPane );
	}
		 

}