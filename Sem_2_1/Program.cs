﻿int num = new Random().Next(10,100);
Console.WriteLine($"Было сгенерировано число {num}");
int x1 = num / 10;
int x2 = num % 10;
if (x1 > x2)
    Console.WriteLine($"Наибольшая цифра это {x1}");
else if (x1 == x2)
    Console.WriteLine("Все цифры этого числа равны");
else
    Console.WriteLine($"Наибольшая цифра это {x2}");

    /// Нахождение наибольшей цифры в 2х значном числе

    // Выведем в стоку все числа от 1 до сгенерированного

for (int i = 1; i<=num; i++)
    Console.Write(i + " ");