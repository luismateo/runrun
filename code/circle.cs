using System;

public class Circle
{
	protected static int origRow;
    protected static int origCol;

	/// string s, int x coordinate, int y coordinate
    protected static void WriteAt(string s, int x, int y)
    {
    try
        {
        Console.SetCursorPosition(origCol+x, origRow+y);
        Console.Write(s);
        }
    catch (ArgumentOutOfRangeException e)
        {
        Console.Clear();
        Console.WriteLine(e.Message);
        }
    }
    
    static void CircleAt(int xcenter, int ycenter, int d, string s)
    {
		int xpoint, ypoint;
		int sectors = d;
		double radius = d/2;
		// pintar circunferencia
		for (int i=0; i < sectors; i++)
		{
			xpoint = xcenter + Convert.ToInt32(Math.Cos(i*2*Math.PI/sectors)*radius);
			ypoint = ycenter + Convert.ToInt32(Math.Sin(i*2*Math.PI/sectors)*radius);
			
			WriteAt(s, xpoint, ypoint);
			
			/* // Mostrar valores de consola y trigonométricos
			 * Console.WriteLine("{0} {1} {2} {3}", xpoint, ypoint,
				Math.Cos(i*(Math.PI/2)),
				Math.Sin(i*(Math.PI/2)));*/
			
		}
	}

	
	public static void Main()
	{

		
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		Console.Clear();
		string symbolN = ".";
		string symbolA = "A";
		string symbolB = "B";
		int diameter = 31;
		int circlemargin = 2; 
		//int sectors = 24;
		int xcircleL, ycircleL, xcircleR, ycircleR;

		int origRow = Console.CursorTop;
		int origCol = Console.CursorLeft;
		
		xcircleL = circlemargin + diameter/2;
		ycircleL = circlemargin + diameter/2;
		xcircleR = xcircleL + diameter + circlemargin;
		ycircleR = ycircleL;
		
		// pintar centro		
		//WriteAt(symbolA, circleoriginx, circleoriginy);
		
		// pintar circunferencia
		CircleAt(xcircleL, ycircleL, diameter, symbolA);
		CircleAt(xcircleR, ycircleR, diameter, symbolB);

		WriteAt("FIN", 0, diameter + circlemargin + 1);
		
	}
}
