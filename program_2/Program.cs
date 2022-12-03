//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет 
Console.Clear();
int NumbSet(int var)
{
    Console.Write("Введите число: ");
    var = int.Parse(Console.ReadLine());
    return var;
}
void NumbCheck (int var1, int var2 )
{
    if( var1/var2 == var2 || var2/var1 == var1 )
    {
       if (var1>var2)
       {
        Console.WriteLine($"Число {var1} является квадратом числа {var2}");
        }
       else
       {
        Console.WriteLine($"Число {var2} является квадратом числа {var1}");
        }
    }
    else
    { 
        if (var1>var2)
        {
            Console.WriteLine($"Число {var1} не является квадратом числа {var2}");
            }
        else
        {
            Console.WriteLine($"Число {var2} не является квадратом числа {var1}");
        }
    }

}
int var = 0;
int numb = NumbSet(var);
int numb2 = NumbSet(var);
NumbCheck(numb,numb2);

