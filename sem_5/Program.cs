Console.WriteLine("введите число");
int num = Convert.ToInt32( Console.ReadLine() );
int numR = (num * -1);
while (numR <= num)
{
    Console.Write(numR + " ");
    numR++;
}