/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B
*/ 

int GetNumber()
{
    while(true)
    {
        string valueFromConsole = Console.ReadLine();

        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number > 0) 
                return number;
            else
            {
                Console.WriteLine("Число должно отличаться от 0. Введите другое число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Введите число отличное от 0.");
        }
    }
}
Console.WriteLine("Введите число A: ");
int firstNumber = GetNumber();
Console.WriteLine("Введите число B: ");
int secondNumber = GetNumber();

int result = 1;

for (int i = 0; i < secondNumber; i++)
{
    result = result * firstNumber;
}
Console.WriteLine($"{firstNumber} ^ {secondNumber} = {result}");