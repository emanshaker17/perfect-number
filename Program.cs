internal class Program
{
    private static void Main(string[] args)
    {
       int n1, n2;
        Console.WriteLine("Get All Perfect In Range of Between two Number");
        Console.Write("Enter Starting Number : ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Ending Number : ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Below are the perfect number between " + n1 + " and " + n2);

        for (int i = n1; i <= n2; i++)
        {
            int sum = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                    sum = sum + j;
            }
            if (sum == i)
                Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}