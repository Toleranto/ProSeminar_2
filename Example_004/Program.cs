//Программа проверяет кратно ли число 7 и 23
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int multiple = a % 7;
if (multiple == 0) Console.WriteLine($"Число кратно 7");
int multiple2 = a % 23;
if (multiple2 == 0) Console.WriteLine($"Число кратно 23");


