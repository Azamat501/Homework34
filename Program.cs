// задача 34; Задайте массив заполненный случайными полжительными трёхзначными числами.
// которая пакажет количество чётных чисел в массиве
Console.WriteLine("Ввудите ваш массив!");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);
int count = 0;
for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
 {   for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();  
 }