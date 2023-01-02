namespace taskfive
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a = int. Parse(Console.ReadLine());
            int b = int. Parse(Console.ReadLine());

            int kvadrati;
            for ( int i = (int)Math.Sqrt(a); i <= (int)Math.Sqrt(b); i++ )
            { 
                kvadrati = i * i;
                if (kvadrati  >= a)
                    Console.WriteLine(kvadrati );

            }
    
            Console.WriteLine("Count:" ); 
        }
    }
}