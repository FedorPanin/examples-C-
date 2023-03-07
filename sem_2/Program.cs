Console.WriteLine("большее число");
int num1 = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("меньшее число");
int num2 = Convert.ToInt32( Console.ReadLine() );

if (num1 == num2 * num2)
{
    Console.WriteLine("является корнем");
}
else
    Console.WriteLine("НЕ является!");