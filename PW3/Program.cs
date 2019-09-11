using System;

namespace PW3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========================  1
            //var rand = new Random();
            //int rowB = 3;
            //int columnB = 4;
            //int[] arrayA = new int[5];
            //double[,] arrayB = new double[rowB, columnB];
            //double sum = 0;
            //double composition = 1;
            //int sumEvenA = 0;
            //double[] arraySumOddB = {0,0};
            //Console.WriteLine("Заполните массив целых чисел из 5 эллементов:");
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += arrayA[i];
            //    composition *= arrayA[i];
            //    if (i % 2 == 0)
            //    {
            //        sumEvenA += arrayA[i];
            //    }
            //}
            //double max = arrayA[0];
            //double min = arrayA[0];
            //Console.WriteLine("arrayB: ");
            //for(int i = 0; i < rowB; i++)
            //{
            //    for (int j = 0, k = 0; j < columnB; j++)
            //    {
            //        arrayB[i,j] = rand.NextDouble()*100;
            //        Console.Write(arrayB[i, j] + "  ");
            //        if (arrayB[i, j] > max)
            //        {
            //            max = arrayB[i, j];
            //        }
            //        else if (arrayB[i, j] < min)
            //        {
            //            min = arrayB[i, j];
            //        }
            //        if (j % 2 == 1)
            //        {
            //            arraySumOddB[k] += arrayB[i, j];
            //            k++;
            //        }
            //        sum += arrayB[i, j];
            //        composition *= arrayB[i, j];
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("arrayA: ");
            //foreach(var item in arrayA)
            //{
            //    Console.Write(item + " ");
            //    if (item > max)
            //    {
            //        max = item;
            //    }
            //    else if (item < min)
            //    {
            //        min = item;
            //    }
            //}
            //Console.WriteLine($"\nОбщий максимальный элемент: {max}");
            //Console.WriteLine($"Общий минимальный  элемент: {min}");
            //Console.WriteLine($"Oбщую суммa всех элементов: {sum}");
            //Console.WriteLine($"Общее произведение всех элементов: {composition}");
            //Console.WriteLine($"Cумму четных элементов массива А: {sumEvenA}");
            //Console.WriteLine("Cумму нечетных столбцов массива В:");
            //foreach(var item in arraySumOddB)
            //{
            //    Console.Write(item+" ");
            //}

            //Даны 2 массива размерности M и N соответственно. 
            //Необходимо переписать в третий массив общие элементы первых двух массивов без повторений. 

            /*int sizeM = Convert.ToInt32(Console.ReadLine());
            int sizeN = Convert.ToInt32(Console.ReadLine());
            int sizeCommon = 0;
            Random rand = new Random();
            int[] arrayM = new int[sizeM];
            int[] arrayN = new int[sizeN];
            int[] arrayCommon = new int[sizeM > sizeN ? sizeN : sizeM];
            bool isRepeat;
            Console.Write("ArrayM: ");
            for (int i = 0; i < sizeM; i++)
            {
                arrayM[i] = rand.Next(0, 10);
                Console.Write($"{arrayM[i]} ");
            }
            Console.Write("\nArrayN: ");
            for (int i = 0; i < sizeN; i++)
            {
                arrayN[i] = rand.Next(0, 10);
                Console.Write($"{arrayN[i]} ");
            }
            for(int i = 0; i < arrayM.Length; i++)
            {
                isRepeat = false;
                for (int j = 0; j < arrayN.Length; j++)
                {
                    if (arrayM[i] == arrayN[j])
                    {
                        for (int l = 0; l < arrayCommon.Length; l++)
                        {
                            if (arrayM[i] == arrayCommon[l])
                            {
                                isRepeat = true;
                            }
                        }
                        if (!isRepeat)
                        {
                            arrayCommon[sizeCommon] = arrayM[i];
                            sizeCommon++;
                        }
                    }
                }
            }
            Console.Write("\nArrayCommon: ");
            for (int i = 0; i < sizeCommon; i++)
            {
                Console.Write($"{arrayCommon[i]} ");
            }*/

            //Пользователь вводит строку.Проверить, является ли эта строка палиндромом.
            //Палиндромом называется строка, которая одинаково читается слева направо и справа налево

            /*Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            text = text.Replace(" ", string.Empty);
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    Console.Write("НЕ ");
                    break;
                }
            }
            Console.Write("Полиндром!");*/

            //Подсчитать количество слов во введенном предложении.

            /*var text = Console.ReadLine();
            text = text.Trim(' ');
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            var words = text.Split(' ');
            Console.WriteLine($"слов в предложении: {words.Length}");*/

            //Дан двумерный массив размерностью 5?5, 
            //заполненный случайными числами из диапазона от –100 до 100. 
            //Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.

            /*Random rand = new Random();
            int[,] array = new int[5,5];
            int maxNumber = -100;
            int minNumber = 100;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int sum = 0;
            bool isMin = false;
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                    if (array[i, j] > maxNumber)
                    {
                        maxNumber = array[i, j];
                    }
                    else if(array[i,j] < minNumber)
                    {
                        minNumber = array[i, j];
                    }
                }
            }

            foreach(int number in array)
            {
                Console.Write($"{number} ");
                if(number == minNumber || number == maxNumber)
                {
                    isMin = !isMin;
                }
                else if(number == minNumber || number == maxNumber)
                {
                    isMin = !isMin;
                }
                if (isMin)
                {
                    sum += number;
                }
            }
            Console.WriteLine("sum: " + sum);*/

            Console.ReadKey();
        }
    }
}
