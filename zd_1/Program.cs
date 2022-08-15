//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


Console.WriteLine("ВВедите колличество чисел : ");
int amount = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 1; i <= amount; i++)
{
    Console.WriteLine("ВВедите число #" + i + ":");
    if (int.Parse(Console.ReadLine()) > 0)
    {
        count++;
    }
}

Console.WriteLine("Чисел больше нуля:" + count);