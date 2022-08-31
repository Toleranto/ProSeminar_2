// See https://aka.ms/new-console-template for more information
//Напишите программу котррая принимает на вход 2 числа 
// и проверяет является ли 1 квадратом второго
// MY CODE
// //Console.Clear();
// Console.WriteLine("Введите первое число для проверки :");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число для проверки : ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sqr1 = num1 * num1;
// int sqr2 = num2 * num2;
// if (sqr2 == num1)
// {
//     Console.WriteLine($"Число {num1}-является квадратом числа {num2}");
// }
// else
// {
//     Console.WriteLine($"Число {num1}-не является квадратом числа {num2}");
// }
// if (sqr1 == num2)
// {
//     Console.WriteLine($"Число {num2}-является квадратом числа {num1}");
// }
// else
// {
//     Console.WriteLine($"Число {num2}-не является квадратом числа {num1}");
// }

Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine()!;
int a;

bool result1 = int.TryParse(number1, out a);
if (result1)
    Console.WriteLine($"Значение {a} введено корректно");
else
    Console.WriteLine("Некорректный ввод данных");

Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine()!;
int b;

bool result2 = int.TryParse(number2, out b);
if (result2)
    Console.WriteLine($"Значение {b} введено корректно");
else
    Console.WriteLine("Некорректный ввод данных");
if (a == b * b) Console.WriteLine($"Первое число {a} является квадратом второго числа {b}");
else if (b == a * a)
{
    Console.WriteLine($"Второе число {b} является квадратом первого числа {a}");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого числа");
}
