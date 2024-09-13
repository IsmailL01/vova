// 3. Найти значение функции y = 4*(x−3)^6 − 7*(x−3)^3 + 2 при данном значении x.

class Program3
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);
        
        int rel = 4*(x-3)*(x-3)*(x-3)*(x-3)*(x-3)*(x-3)-7*(x-3)*(x-3)*(x-3)+2;

        


        Console.WriteLine(rel);
        
    }
}