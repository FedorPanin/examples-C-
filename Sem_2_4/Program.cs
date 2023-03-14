Console.WriteLine("add num 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("add num 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int max;

if (num2 > num1)
    {max = num2;
    num2 = num1;
    num1 = max;
    }

int res = num2 * num2;
if (res == num1)
    Console.WriteLine($"число {num1} является квадратом числа {num2}");
else
    Console.WriteLine($"число {num1} не является квадратом числа {num2}");

// проверка является ли число 1 квадратом числа 2
// не имеет значения в каком порядке вводить