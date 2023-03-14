Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32 (Console.ReadLine());

if (num > 999)
    Console.WriteLine("error");
else if (num < 100)
    Console.WriteLine("error");

string i = Convert.ToString(num);

Console.Write(i[0].ToString() + i[2].ToString());


// При вводе любого числа(в данном случае 3х значного)
// Выводим в консоль цифры все кроме той которую не хотим показввать
// В данном случает убирается вторая цифра числа
// через параметр i[].Tostring() делается вывод определенного символа под индексом[]