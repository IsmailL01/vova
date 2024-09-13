class Pr1
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        int V1 = Convert.ToInt32(a);

        string b = Console.ReadLine();
        int V2 = Convert.ToInt32(b);

        string c  = Console.ReadLine();
        int T = Convert.ToInt32(c);

        string d  = Console.ReadLine();
        int S = Convert.ToInt32(d);

        
        int rast = V1 * T;
        int rast2 = V2 * T; 
        int rel = rast + rast2 + S;

        Console.WriteLine(rel);
    }
}