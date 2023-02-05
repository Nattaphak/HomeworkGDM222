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
    }
} 