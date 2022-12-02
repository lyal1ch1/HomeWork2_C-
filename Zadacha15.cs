Console.Clear();
Console.WriteLine("Введите цифру, обазначающую день недели");
Console.WriteLine("Например, 1-пн, 3-ср, 7-вс");

int num = int.Parse(Console.ReadLine()!);

if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine("Рабочий день");
}
    
if (num == 6 || num == 7)
{
  Console.WriteLine("Выходной сегодня :)  ");  
}

if (num < 1 || num> 7)
{
    Console.WriteLine("Такого дня недели нет!");
}