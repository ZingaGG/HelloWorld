
// Task 1

System.Console.WriteLine("Input a = ");
int a = Int32.Parse(Console.ReadLine());
int res = 0;

for (int i = 0; i < 2; i++)
{
    if (i == 1)
    {
        res = a % 10;
    }
    a = a / 10;
}

System.Console.WriteLine("Result = " + res);