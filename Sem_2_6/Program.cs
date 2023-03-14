int num = new Random().Next(1, 100000);
Console.WriteLine($"вводное {num}");
int firstnum;
int secondnum;
string pasnum = "";
if (num > 10)
{
    while (num > 99)
    {
        pasnum = Convert.ToString(num % 10) + pasnum;
        num = num / 10;
    }
    secondnum = num % 10;
    firstnum = num /10;
    Console.WriteLine($"результат {firstnum}{pasnum}");
}
 // способ убрать второй символ из числа через модуль и деление остатка.