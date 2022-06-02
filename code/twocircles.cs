using System;
using System.Threading;

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
    
    static void CircleAt(int xcenter, int ycenter, int d, int sec, string sym)
    {
		int xpoint, ypoint;
		double radius = d/2;
		// pintar circunferencia
		for (int i=0; i < sec; i++)
		{
			xpoint = xcenter + Convert.ToInt32(Math.Cos(i*2*Math.PI/sec)*radius);
			ypoint = ycenter + Convert.ToInt32(Math.Sin(i*2*Math.PI/sec)*radius);
			
			WriteAt(s, xpoint, ypoint);
			
			/* // Mostrar valores de consola y trigonométricos
			 * Console.WriteLine("{0} {1} {2} {3}", xpoint, ypoint,
				Math.Cos(i*(Math.PI/2)),
				Math.Sin(i*(Math.PI/2)));*/
			
		}
	}
	
	static void CircleCoord(int xcenter, int ycenter, int d, int sec)
	{
		int xpoint, ypoint;
		double radius = d/2;
		// pintar circunferencia
		for (int i=0; i < sec; i++)
		{
			xpoint = xcenter + Convert.ToInt32(Math.Cos(i*2*Math.PI/sec)*radius);
			ypoint = ycenter + Convert.ToInt32(Math.Sin(i*2*Math.PI/sec)*radius);
			
			coord[] = xpoint;
			coord[] = ypoint;
			
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
		const int DIAMETER = 31;
		int circlemargin = 2; 
		int sectors = 24;
		int xcircleL, ycircleL, xcircleR, ycircleR;
		ConsoleKey tecla;
		int [,,] coord = new int[2, sectors, sectors];

		int origRow = Console.CursorTop;
		int origCol = Console.CursorLeft;
		
		xcircleL = circlemargin + DIAMETER/2;
		ycircleL = circlemargin + DIAMETER/2;
		xcircleR = xcircleL + DIAMETER + circlemargin;
		ycircleR = ycircleL;
		
		// pintar centro		
		//WriteAt(symbolA, circleoriginx, circleoriginy);
		
		// pintar circunferencia
		CircleAt(xcircleL, ycircleL, DIAMETER, sectors, symbolA);
		CircleAt(xcircleR, ycircleR, DIAMETER, sectors, symbolB);

		WriteAt("FIN", 0, DIAMETER + circlemargin + 1);
		
		do
		{
                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(100); //milliseconds
                }
                tecla = Console.ReadKey(true).Key;
        } while (tecla != ConsoleKey.Escape);
		Console.WriteLine("Se acabó por ahora.");
	} // End of Main
}
