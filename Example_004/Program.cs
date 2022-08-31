//Программа проверяет кратно ли число 7 и 23
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int multiple = a % 7;
// int multiple2 = a % 23;
// if (multiple == 0) 
// {
//     Console.WriteLine("Число кратно 7");
// }    
// if (multiple2 == 0) 
// {
//   Console.WriteLine("Число кратно 23");
// }
// else Console.WriteLine("Число не кратно, ни 7 ни 23");

Console.Clear();
Console.WriteLine("Введите число для проверки кратности:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число для проверки кратности:");
int even1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки кратности: ");
int even2 = Convert.ToInt32(Console.ReadLine());
if (num % even1 == 0 && num % even2 == 0)
{
    Console.WriteLine($"{num} - является кратным  {even1} и {even2}" );
}
else
{
    Console.WriteLine($"{num} - не  является кратным  {even1} и {even2}" );
}

