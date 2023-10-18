// Задайте значение N. напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> “5,4,3,2,1”
//N = 8 -> “8,7,6,5,4,3,2,1”


Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

        // if (n >= 1)
        // {
    PrintNumbers(n);
        //}
        // else
        // {
        //     Console.WriteLine("Значение N должно быть больше или равно 1.");
        // }

void PrintNumbers(int n)
    {
    if (n >= 1)
    {
        Console.Write($"{n}, ");
        PrintNumbers(n - 1);
    }
        // else
        // {
        //     return;
        // }
    }

   

    