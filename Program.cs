using System;

namespace Task_1
{
    /*
     
    Задача:
    Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу.
    Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.
    
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int SUM = 31;
            int[] array = { -2,-3, 8, 5, -1, 6, 29, 18, 10, 7, 4 };
                                 
            int tempSum = SUM;
            int countCombination = 0;

            Console.WriteLine($"Сумма чисел должна быть равна: {SUM}\n");

            HashSet<int> set = new HashSet<int>();
            
            int count = 0;            
            foreach (var item in array)
            {
                tempSum -= item;
                count++;
                for(int i = count; i < array.Length; i++)
                {
                    if (set.Contains(tempSum - array[i]))
                    {
                        countCombination++;
                        Console.WriteLine($"{countCombination} комбинация: {array[i]}  {item}  {SUM - array[i] - item}");
                        set.Clear();
                        Console.WriteLine();
                    }                     
                    else
                    {
                        set.Add(array[i]);                       
                    }                                      
                }
                set.Clear();
                tempSum = SUM;
            }
            if (countCombination == 0)
                Console.WriteLine("Ни одной комбинации не найдено");

            Console.ReadLine();
        }
    }
}
