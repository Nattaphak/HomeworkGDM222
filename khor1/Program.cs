public class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        int n = 0 ;

        while(Math.Pow(x,2) > 4)
        {
            n = n+1;
            x = x - ((4 * Math.Abs(x)/x));
        }
        x = n+2;
        Console.WriteLine(x);

        Console.ReadLine();
    }
}

