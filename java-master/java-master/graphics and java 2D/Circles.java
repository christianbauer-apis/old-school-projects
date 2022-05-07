/*
This program draws eight concentric circles by using the drawArc method from the Graphics class and
draws each circle a black color.
*/

import java.awt.Color;
import java.awt.Graphics;
import javax.swing.JPanel;

public class Circles extends JPanel {

	public void paintComponent( Graphics g ) {

		super.paintComponent( g );

		g.setColor( Color.BLACK );
		g.drawArc( 350, 200, 80, 80, 0, 360 );

		g.setColor( Color.BLACK );
		g.drawArc( 340, 190, 100, 100, 0, 360 );

		g.setColor( Color.BLACK );
		g.drawArc( 330, 180, 120, 120, 0, 360 );

		g.setColor( Color.BLACK );
		g.drawArc( 320, 170, 140, 140, 0, 360 );

		g.setColor( Color.BLACK );
		g.drawArc( 310, 160, 160, 160, 0, 360 );

		g.setColor( Color.BLACK );
		g.drawArc( 300, 150, 180, 180, 0, 360 );

		g.setColor( Color.BLACK );
		g.drawArc( 290, 140, 200, 200, 0, 360 );

		g.setColor( Color.BLACK );
		g.drawArc( 280, 130, 220, 220, 0, 360 );

	}
}