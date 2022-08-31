
//if (b > a) Console.WriteLine("Второе число > первого числа");
//Написать программу которая на вход принимает 2 числа
// проверяет кратность одного другому и выводит остаток деления.
Console.Clear();
Console.WriteLine("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int remain = a % b;
if (remain == 0) Console.WriteLine($"Первое число кратно второму");
else Console.WriteLine($"Остаток от деления-> {remain}");
