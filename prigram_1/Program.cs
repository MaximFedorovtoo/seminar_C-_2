Console.Clear();
Console.Write("Введите первое число ");
int numb = int.Parse(Console.ReadLine());
Console.Write("ВВедите второе число ");
int numb2 = int.Parse(Console.ReadLine());

if(161 % 7 == 0 & 161 % 23 == 0)
{
    Console.WriteLine($"Числа {numb} и {numb2} кратны 161.");
}
else
{
    Console.WriteLine($"Числа {numb} и {numb2} не кратны 161.");
}