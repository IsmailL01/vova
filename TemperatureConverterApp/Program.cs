class Program2
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        int TF = Convert.ToInt32(a);
        
       int rel = (TF-32)*5/9;

        Console.WriteLine(rel);
    }
}