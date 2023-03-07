Console.WriteLine("Введите целое число");
int num = Convert.ToInt32( Console.ReadLine() );
int res = num * num;
Console.WriteLine("Квадрат введенного числа равен "+res);

if (num==5)
{
    Console.WriteLine("Пятерочка!");
}
else
    Console.WriteLine("Не пятерочка!");