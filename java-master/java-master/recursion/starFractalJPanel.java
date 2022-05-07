/*
This program creates the five lines that are in the shape of a star. Then when the user increases a
level in the fractal it creates the extra lines for each increased level.
*/
import java.awt.Graphics;
import java.awt.Color;
import java.awt.Dimension;
import javax.swing.JPanel;

public class starFractalJPanel extends JPanel
{
	private Color color;
	private int level;

	private final int WIDTH = 400;
	private final int HEIGHT = 400;

	public starFractalJPanel( int currentLevel )
	{
		color = Color.BLUE;
		level = currentLevel;
		setBackground( Color.WHITE );
		setPreferredSize( new Dimension( WIDTH, HEIGHT ) );
	}

	public void drawFractal( int level, int xA, int yA, int xB, int yB, Graphics g )
	{
		if ( level == 0 )
			g.drawLine( xA, yA, xB, yB );
		else
		{
			int xC = (xA + xB ) / 2;
			int yC = (yA + yB ) / 2;

			int xD = xA + ( xC - xA ) / 2 - ( yC - yA ) / 2;
			int yD = yA + ( yC - yA ) / 2 + ( xC - xA ) / 2;

			drawFractal( level - 1, xD, yD, xA, yA, g );
			drawFractal( level - 1, xD, yD, xC, yC, g );
			drawFractal( level - 1, xD, yD, xB, yB, g );
		}
	}

	public void paintComponent( Graphics g )
	{
		super.paintComponent( g );

		g.setColor( color );
		drawFractal( level, 140, 280, 215, 80, g );
		drawFractal( level, 215, 80, 290, 280, g );
		drawFractal( level, 290, 280, 110, 157, g );
		drawFractal( level, 110, 157, 325, 157, g );
		drawFractal( level, 325, 157, 140, 280, g );

	}

	public void setColor( Color c )
	{
		color = c;
	}

	public void setLevel( int currentLevel )
	{
		level = currentLevel;
	}

	public int getLevel()
	{
		return level;
	}
}