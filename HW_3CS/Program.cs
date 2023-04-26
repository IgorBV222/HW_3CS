using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3CS
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Пользователь вводит 4-хзначное число. Программа должна вывести полученное число в обратном порядке.");
            Console.WriteLine("Введите 4-х значное число");
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine("\nЗадача 2. Пользователь вводит 6-тизначное число. Программа должна вывести в столбик все чётные цифры этого числа.");
            string input1;
            int tmp;
            Console.WriteLine("Введите 6-и значное число");
            input1 = Console.ReadLine();
            {
                try
                {
                    for (int i = 0; i < input1.Length; i++)
                    {
                        tmp = int.Parse(input1[i].ToString());
                        if (tmp % 2 == 0)
                        {
                            Console.WriteLine(tmp);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ввод некорректен!");
                }
            }           
            Console.WriteLine("\nЗадача 3. Программа должна позволять считать время, за которое спортсмен пробегает круг. \r\nДля старта измерений использовать клавиша \"Enter\", получение отметки пройденного круга - \"Enter\", конец забега и вывод результатов - клавиша \"Пробел\".\n");
            Console.WriteLine("Для начала/окончания забега по кругу нажмите -> ENTER\nДля конца забега и вывода результата нажмите -> ПРОБЕЛ");
            ConsoleKeyInfo key = Console.ReadKey();
            DateTime allTime = default(DateTime);
            int circle = 0;
            while (key.Key != ConsoleKey.Spacebar)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    circle++;
                    Console.WriteLine($"\nСтарт забега по кругу - {circle.ToString()}");
                    DateTime startTime = DateTime.Now;
                    Console.WriteLine(startTime.ToString("HH:mm:ss.ffffff"));
                    Console.ReadKey();
                    DateTime stopTime = DateTime.Now;
                    TimeSpan timeSpan = stopTime - startTime;
                    Console.WriteLine($"\nКруг - {circle.ToString()} пробежал за {timeSpan.ToString("ss")} секунд и {timeSpan.ToString("fff")} миллисекунд");
                    allTime += timeSpan;
                }
            }
            Console.WriteLine($"\nПройдено кгругов - {circle.ToString()}. Общее время забега {allTime.ToString("ss")} секунд и {allTime.ToString("fff")} миллисекунд.");
             
            /*Console.WriteLine("Задача 4. Пользователю предлагается ввести данные показаний счётчика для горячей (ГВС) и холодной (ХВС) воды\nв формате 8-мизначных чисел по месяцам от января до декабря." +
                "\nПрограмма должна контролировать техническую корректность ввода данных (не давать вводить строку вместо числа)," +
                "\nлогическую корректность (показания следующего месяца не должны быть меньше показаний предыдущего)" +
                "\nи иметь обявленную клавишу выхода из процедуры ввода.\r\nЗавершение ввода программы - вывод таблицвы потребления по месяцам и суммируюущую строку за год.\n");*/
        }
    }
}
