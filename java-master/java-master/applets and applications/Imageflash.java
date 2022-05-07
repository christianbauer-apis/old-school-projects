/*
This applet flashes between two images, a plain red background and a stop sign.
*/

import java.awt.Graphics;
import java.awt.Image;
import javax.swing.JApplet;
import java.util.*;

public class Imageflash extends JApplet
{
	private Image image1;
	private Image image2;
	Timer timer;
    int delay;        
	boolean image;

	public void init()
	{
		String blinkFrequency = getParameter("speed");
        delay = (blinkFrequency == null) ? 400 :
        (1000 / Integer.parseInt(blinkFrequency));
		image1 = getImage( getDocumentBase(), "stop.gif" );
		image2 = getImage( getDocumentBase(), "background.gif" );
		setSize(500, 500);
		image = false;
	}



	public void paint( Graphics g )
	{
		super.paint( g );
		if(image)
		g.drawImage( image1, 0, 120, getWidth(), getHeight() - 120, this );
		else
		g.drawImage( image2, 20, 120, getWidth()-50, getHeight()-50, this );
	}


    public void start() 
	{
        timer = new Timer();
        timer.schedule(new TimerTask() 
		{
            
			public void run() 
			{
				while (true)
				{
					image =! image;
					repaint();
					try 
					{
						Thread.sleep(1000);
					}
					catch (InterruptedException e) {}
	

				}
			}
        }, delay);
    }
	
    public void stop() 
	{
        timer.cancel();
    }


}
 

       
     

  


