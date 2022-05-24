/* Напишите программу, которая задает массив из 8-ми 
элементов и выводит их на экран.
*/ 
void FillArray(int[] collection)
{
    Random randomeiser = new Random();

    for(int i = 0; i < collection.Length; i++)
    {    
        collection[i] = randomeiser.Next(0, 10);
    }
}
int[] array = new int[8];
FillArray(array);

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();