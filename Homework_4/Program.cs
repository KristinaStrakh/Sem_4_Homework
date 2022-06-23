/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


/*Console.WriteLine("Введите число1: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = 1;
int i = 1;


while(i <= num2)
{
    sum *= num;
    i++;
}

Console.Write(sum);*/


//через for задача 25

/*Console.WriteLine("Введите число1: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = 1;


for (int i = 1; i <= num2; i++)
{
    sum *= num;
}

Console.Write(sum);*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
    sum = sum + num % 10;
    num = num/10;
}

Console.Write(sum);*/

/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]*/

int[] array = new int[8];

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 34);
        Console.Write(array[i] + " ");
    }

}

PrintArray(array);

