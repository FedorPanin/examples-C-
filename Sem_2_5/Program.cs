Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int x = num % 7;
int z = num % 23;
if ( x + z == 0 )
    Console.WriteLine("кратно 7 и 23");
else
    Console.WriteLine("не кратно");

// проверка числа на кратность сразу 2м числам 