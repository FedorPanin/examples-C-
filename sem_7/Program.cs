Console.WriteLine("введите любое число больше 3х знаков");
int num = Convert.ToInt32(Console.ReadLine());
int ostatok = 0;
if (num < 100)
{
    Console.WriteLine("в вашем числе меньше 3х знаков");
}
else
    if (num <= 999)
    {
    ostatok = num % 10;  
    }
    else
        while (num > 999)
        {
            num = (num / 10);
            ostatok = num % 10;
        }
Console.WriteLine(ostatok);

// прорамма выводи 3-ю цифру слева в любом числе