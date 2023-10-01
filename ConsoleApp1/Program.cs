using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"введите {i + 1}|{j + 1} элемент :: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Найти такие k, при которых k-ая строка матрицы совпадает с k-столбцом
        Console.WriteLine("К-тые строки/столбцы совпадают:");
        for (int k = 0; k < 8; k++)
        {
            bool match = true;
            for (int i = 0; i < 8; i++)
            {
                if (matrix[k, i] != matrix[i, k])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                Console.WriteLine(k + 1);
            }
        }

        // Найти сумму элементов в тех строках, которые содержат хотя бы один отрицательный элемент
        int sum = 0;
        for (int i = 0; i < 8; i++)
        {
            bool hasNegative = false;
            for (int j = 0; j < 8; j++)
            {
                if (matrix[i, j] < 0)
                {
                    hasNegative = true;
                    break;
                }
            }
            if (hasNegative)
            {
                for (int j = 0; j < 8; j++)
                {
                    sum += matrix[i, j];
                }
            }
        }
        Console.WriteLine("Сумма элементов в строках с отрицательными элементами: " + sum);
    }
}