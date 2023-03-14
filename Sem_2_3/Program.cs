Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num1 % num2;
if (res == 0)
    Console.WriteLine($"{num1} кратно {num2}");
else 
    Console.WriteLine($"{num1} не кратно {num2}, остаток " + res);


// проверка на кратность одного числа другим, с выводом остатка.