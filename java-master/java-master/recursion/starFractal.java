/*
This program creates a JFrame and creates all of the buttons to use for the fractal. Then the main method
executes the program.
*/

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JColorChooser;

public class starFractal extends JFrame
{

	private final int WIDTH = 400;
	private final int HEIGHT = 480;
	private final int MIN_LEVEL = 0;
	private Color color = Color.BLUE;

	private JButton changeColorJButton, increaseLevelJButton, decreaseLevelJButton;
	private JLabel levelJLabel;
	private starFractalJPanel drawSpace;
	private JPanel mainJPanel, controlJPanel;

	public starFractal()
	{
		super( "Fractal" );

		controlJPanel = new JPanel();
		controlJPanel.setLayout( new FlowLayout() );

		changeColorJButton = new JButton( "Color" );
		controlJPanel.add( changeColorJButton );
		changeColorJButton.addActionListener(
			new ActionListener()
			{

				public void actionPerformed( ActionEvent event )
				{
					color = JColorChooser.showDialog(
						starFractal.this, "Choose a color", color );

					if ( color == null )
						color = Color.BLUE;

					drawSpace.setColor( color );
				}
			}
		);

		decreaseLevelJButton = new JButton( "Decrease Level" );
		controlJPanel.add( decreaseLevelJButton );
		decreaseLevelJButton.addActionListener(
			new ActionListener()
			{

				public void actionPerformed( ActionEvent event )
				{
					int level = drawSpace.getLevel();
					level--;

					if ( level >= MIN_LEVEL )
					{
						levelJLabel.setText( "Level: " + level );
						drawSpace.setLevel( level );
						repaint();
					}
				}
			}
		);

		increaseLevelJButton = new JButton( "Increase Level" );
		controlJPanel.add( increaseLevelJButton );
		increaseLevelJButton.addActionListener(
			new ActionListener()
			{

				public void actionPerformed( ActionEvent event )
				{
					int level = drawSpace.getLevel();
					level++;

					if ( level >= MIN_LEVEL )
					{
						levelJLabel.setText( "Level: " + level );
						drawSpace.setLevel( level );
						repaint();
					}
				}
			}
		);

		levelJLabel = new JLabel( "Level: 0" );
		controlJPanel.add( levelJLabel );

		drawSpace = new starFractalJPanel( 0 );

		mainJPanel = new JPanel();
		mainJPanel.add( controlJPanel );
		mainJPanel.add( drawSpace );

		add( mainJPanel );

		setSize( WIDTH, HEIGHT );
		setVisible( true );
	}

	public static void main( String args[] )
	{
		starFractal demo = new starFractal();
		demo.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
	}
}