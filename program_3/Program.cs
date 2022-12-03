Console.Clear();
int rand = new Random().Next(10,99);
Console.WriteLine($"Случайное число равно: {rand}");
int var1 = rand % 10;
rand = rand / 10;
int max = 0;
if (var1 > rand){max = var1;}
if (rand > var1) {max = rand;}
Console.WriteLine($"Максимальное число равно: {max}");
