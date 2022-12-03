Console.Clear();
int rand = new Random().Next(100,999);
Console.WriteLine($"Случайное число равно: {rand}");
int var1 = (rand / 100) * 10;
int var2 = rand % 10;
int var3 = var1 + var2;
Console.WriteLine($"Убрали второе число: {var3}");