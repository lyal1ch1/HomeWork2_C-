Console.WriteLine("Введите трех-значное число:");
int num = int.Parse(Console.ReadLine()!);

if (num / 10 >= 10)
{
    int result = num / 10;
    int result1 = result % 10;

    Console.WriteLine("Ваше число:" + result1);
}

else
{
    Console.WriteLine("Число не трех-значное!");
}