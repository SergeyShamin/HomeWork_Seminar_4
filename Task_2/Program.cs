/* Напишите программу, которая принимает на вход число 
и выдает сумму цифр в числе.
*/ 

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int summ = 0;

while (number != 0)
{
    int digit = number % 10;
    number /= 10;
    summ = summ + digit;
}

Console.WriteLine($"Сумма чисел: {summ}");