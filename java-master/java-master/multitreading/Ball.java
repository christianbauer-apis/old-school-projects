/*
This program creates randomly colored balls when the user clicks the mouse.
*/

import java.awt.*;
import java.awt.event.*;
import java.awt.geom.*;
import java.util.*;
import java.util.List;
import javax.swing.*;
 
public class Ball extends MouseAdapter 
{
    BallCanvas canvas = new BallCanvas();
    BouncingBall selectedBall = null;


    private void addBall() 
	{
        BouncingBall bb = new BouncingBall(canvas);
        canvas.add(bb);
        bb.start();
    }

    

    public void mousePressed(MouseEvent e) 
	{
	addBall();     

    }


    public static void main(String[] args) 
	{
        Ball test = new Ball();
        test.canvas.addMouseListener(test);
        final int WIDTH = 450;
        final int HEIGHT = 350;
        JFrame frame = new JFrame();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.getContentPane().add(test.canvas);
        frame.setSize(WIDTH, HEIGHT);
        frame.setLocation(200,200);
        frame.setVisible(true);
    }
}

class BallCanvas extends JPanel 
{
    private List <BouncingBall> balls = new ArrayList<BouncingBall>();

    public void add(BouncingBall b) 
	{
            balls.add(b);
    }

    public BouncingBall[] getBalls() 
	{
        int size = balls.size();
        return balls.toArray(new BouncingBall[size]);
    }

    public void paintComponent(Graphics g) 
	{
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D)g;
        g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING,
                            RenderingHints.VALUE_ANTIALIAS_ON);
        for (int i = 0; i < balls.size(); i++) {
            BouncingBall b = (BouncingBall)balls.get(i);
            b.draw(g2);
        }
    }
}
 
class BouncingBall implements Runnable 
{
    private Component canvas;
    private static final int XSIZE = 15;
    private static final int YSIZE = 15;
    private int x = 0;
    private int y = 0;
    private int dx;
    private int dy;
    Color color;
    boolean selected = false;
    Thread thread;
    boolean keepBouncing = false;

    public BouncingBall(Component c) 
	{
        canvas = c;
        color = getColor();
        dx = getSpeed();
        dy = getSpeed();
    }

    public void draw(Graphics2D g2) 
	{
        g2.setColor(color); 
        g2.fillOval(x,y,20,20);   
        if(selected)
            g2.setPaint(Color.magenta);
        g2.drawOval(x,y,20,20);   
    }

    public void start() 
	{
        if(!keepBouncing) 
		{
            keepBouncing = true;
            thread = new Thread(this);
            thread.setPriority(Thread.NORM_PRIORITY);
            thread.start();
        }
    }

    public void stop() 
	{
        keepBouncing = false;
        if(thread != null)
            thread.interrupt();
        thread = null;
    }

    public void run() 
	{
        try {
            while(keepBouncing) 
			{
                move();
                Thread.sleep(50);
            }
        } catch(InterruptedException e) {
            System.out.println("interruption");
            keepBouncing = false;
        }
    }
    
    private void move() 
	{
        x += dx;
        y += dy;
        if (x < 0) 
		{
            x = 0;
            dx = -dx;
        }
        if (x + XSIZE >= canvas.getWidth()) 
		{
            x = canvas.getWidth() - XSIZE;
            dx = -dx;
        }
        if (y < 0) 
		{
            y = 0;
            dy = -dy;
        }
        if (y + YSIZE >= canvas.getHeight()) 
		{
            y = canvas.getHeight() - YSIZE;
            dy = -dy;
        }
        canvas.repaint();
    }

    public boolean contains(Point p) 
	{
        int w = 2*XSIZE;
        int h = 2*YSIZE;
        return new Ellipse2D.Double(x,y,w,h).contains(p);
    }

    public void setSelected(boolean selected) 
	{
        this.selected = selected;
    }
    
    private Color getColor() 
	{
        int rval = 50 + (int)Math.floor(Math.random() * 206);
        int gval = 50 + (int)Math.floor(Math.random() * 206);
        int bval = 50 + (int)Math.floor(Math.random() * 206);
        return new Color(rval, gval, bval);
    }

    private int getSpeed() 
	{
        return 1 + (int)Math.floor(Math.random() * 5);
    }
}