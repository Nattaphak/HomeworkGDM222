public class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        
            while(x <= -1 || x > 1)
            {
                 if(x <= -1)
                {
                     x = x+2;
                }

                else if(x > 1)
                {
                     x = x-2;
                }

            }

            if(x > -1 && x <= 0)
            {
                x = Math.Sqrt(1 - Math.Pow(x,2));

                Console.WriteLine(x);
            }

            else if(x > 0 && x <= 1)
            {
                x = -1* Math.Sqrt(1 - Math.Pow(x,2));

                Console.WriteLine(x);
            }

        Console.ReadLine();

    }
}
