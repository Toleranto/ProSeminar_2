// See https://aka.ms/new-console-template for more information
//Напишите программу котррая принимает на вход 2 числа 
// и проверяет является ли 1 квадратом второго
// 
Console.Clear();
Console.WriteLine("Введите первое число для проверки :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки : ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sqr1 = num1 * num1;
int sqr2 = num2 * num2;
if (sqr2 == num1)
{
    Console.WriteLine($"Число {num1}-является квадратом числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1}-не является квадратом числа {num2}");
}
if (sqr1 == num2)
{
    Console.WriteLine($"Число {num2}-является квадратом числа {num1}");
}
else
{
    Console.WriteLine($"Число {num2}-не является квадратом числа {num1}");
}
    
