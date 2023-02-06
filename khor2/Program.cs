public class Program
{
    static void Main(string[] args)
    {
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());
        double Px = double.Parse(Console.ReadLine());
        double Py = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        double r = Math.Sqrt(Math.Pow((Cx-Px),2) + Math.Pow((Cy-Py),2));

        double theta = Math.Atan((Math.Abs(Cy-Py)/Math.Abs(Cx-Px))) ;

        for(int i = n ; i > 0 ; i--)
        {
            r = r/2;

            Px = ( r * 2 ) * ( Math.Cos ( theta + ( Math.PI / 2 ) ) ) + ( Cx );
            Py = ( r * 2 ) * ( Math.Sin ( theta + ( Math.PI / 2 ) ) )+ ( Cy );

            Cx = r * ( Math.Cos ( theta + ( Math.PI / 2 ) ) ) + ( Cx ) ;
            Cy = r * ( Math.Sin ( theta + ( Math.PI / 2 ) ) ) + ( Cy ) ;

            theta = theta + ( Math.PI / 2);

        }

        Console.WriteLine(Cx);Console.WriteLine(Cy);Console.WriteLine(Px);Console.WriteLine(Py);
    }
} 