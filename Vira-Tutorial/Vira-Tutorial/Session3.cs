namespace Vira_Tutorial;

public class Session3
{
    public static void Run()
    {
        int a = 0;
        int b = 0;
        Console.WriteLine("Please enter two numbers:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        sum = a + b;
        
        Console.Write($"The sum is : {sum}");
    }
}