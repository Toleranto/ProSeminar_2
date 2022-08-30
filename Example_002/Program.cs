// Написать программу которая рандомно берет 
//3-х значное число и удаляет 2-ю цифру
//
//int num = new Random().Next(100, 1000);
//int hund = num / 100;
//int ones = (num-hund*100) % 10;
//Console.WriteLine(num);
//Console.WriteLine($"Получившееся число->{a1}{a3}");

int num = new Random().Next(100, 1000);
int hund = num / 100;
int ones = num % 10; 
int result= hund * 10 + ones;
Console.WriteLine(num);
Console.WriteLine($"Получившееся число->{result}");