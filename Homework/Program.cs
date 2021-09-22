﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Task A1.1");
            Console.Write("Секунд прошло с  начала суток: ");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" {Math.Floor((double)time/3600)} полных часов прошло с начала суток;");
            Console.WriteLine($" {time % 60} полных полных минут прошло с начала очередного часа;");
            Console.WriteLine($" {time % 3600 % 60} сколько полных секунд прошло с начала очередной минуты;");

            Console.WriteLine("\nTask A1.2");
            Console.WriteLine("Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него ? ");
            float count = 543 / 130;
            Console.WriteLine($"Ответ: {Math.Floor(count)}");

            Console.WriteLine("\nTask A1.3");
            Console.Write("Пусть x - порядковый номер текущего месяца.\nВведите сколько меcяцев прошло с 2 января 2020 года: ");
            int x = 1;
            time = Convert.ToInt32(Console.ReadLine());
            x = x + time % 12;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("\nTask A1.4");
            x = random.Next(10, 99);
            int y = (x - x % 10) / 10; // количество десятков числа
            Console.WriteLine($"Дано двузначное число {x}");
            Console.WriteLine($"а) число десятков в нем: {y}");
            Console.WriteLine($"б) число единиц в нем: {x%10}");
            Console.WriteLine($"в) сумму его цифр: {x%10 + y}");
            Console.WriteLine($"г) произведение его цифр: {x % 10 * y}");

            Console.WriteLine("\nTask A1.5");
            x = random.Next(100, 999);
            y = (x - x % 100) / 100; // количество сотен числа
            Console.Write($"Дано трехзначное число {x} (abc)");
            x = x % 100 * 10 + y;
            Console.WriteLine($"Число после форматирования {x} (bca)");

            Console.WriteLine("\nTask A1.6");
            x = 237;
            y = (x - x % 100) / 100; // количество сотен числа
            Console.Write($"Дано трехзначное число {x} (cab)");
            x = x % 100 * 10 + y;
            Console.Write($"Обратно его преобразуя, получили {x} (abc)");

            Console.WriteLine("\nTask A1.7");
            x = random.Next(10, 89);
            y = random.Next(10, 99 - x);
            int a1 = x % 10;
            int a2 = (x - a1) / 10;
            int b1 = y % 10;
            int b2 = (y - b1) / 10;
            Console.WriteLine($"Даны цифры чисел a2a1 и b2b1.\n a2 = {a2}\n a1 = {a1}\n b2 = {b2}\n b1 = {b1}");
            int c1 = b1 + a1;
            int c2 = a2 + b2 + (c1 - c1 % 10) / 10;
            c1 %= 10;
            Console.WriteLine($"a2a1 + b2b1 = c1c2\n c1 = {c1}\n c2 = {c2}");

            Console.WriteLine("\nTask A1.8");
            x = (random.Next(49) + 1) * 3;
            Console.WriteLine($"k  = 3n (k<150, n есть число натуральное) k = {x}");
            x = x % 30 / 3;
            Console.WriteLine($"Цифра с порядковым номером k  - {x}");
            x = random.Next(49) * 3 + 1;
            Console.WriteLine($"k  = 3n + 1 (k<150, n есть число натуральное) k = {x}");
            x = 1 + (x - x % 300) / 300;
            Console.WriteLine($"Цифра с порядковым номером k  - {x}");
            x = random.Next(49) * 3 + 2;
            Console.WriteLine($"k  = 3n + 2 (k<150, n есть число натуральное) k = {x}");
            x = (x - x % 30) / 30;
            Console.WriteLine($"Цифра с порядковым номером k  - {x}");



            Console.WriteLine("\nTask A1.9");
            Console.WriteLine("А = Истина, В = Ложь, С = Ложь");
            Console.WriteLine($"а) А или В = {true || false}\nб) А и В = {true && false}\nв) В или С = {false || false}");

            Console.WriteLine("\nTask A1.10");
            Console.WriteLine("Задайте логические величины X, Y и Z( 0 - false 1 - true)");
            Console.Write("Введите логическое X = ");
            bool xBool = ('1' == Console.ReadKey().KeyChar);
            Console.Write("\nВведите логическое Y = ");
            bool yBool = ('1' == Console.ReadKey().KeyChar);
            Console.Write("\nВведите логическое Z = ");
            bool zBool = ('1' == Console.ReadKey().KeyChar);
            Console.WriteLine($"\nа) не (X или Y) и (не X или не Z) = {!(xBool||yBool) && (!xBool || !zBool)}");
            Console.WriteLine($"\nб) не (не X и Y) или (X и не Z) = {!(!xBool && yBool) || (xBool && !zBool)}");
            Console.WriteLine($"\nв) X или не Y и не (X или не Z) = {xBool || !yBool && !(xBool || !zBool)}");

            Console.WriteLine("\n1. Противоположности притягиваются");
            Console.Write("Введите количество лепестков цветка Тимми: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество лепестков цветка Сара: ");
            y = Convert.ToInt32(Console.ReadLine());
            if (Love(x, y))
            {
                Console.WriteLine("Тимми и Сара влюблены");
            }
            else
            {
                Console.WriteLine("Очень жаль.... но Тимми и Сара не влюблены");
            }

            Console.WriteLine("\n2. Избегайте обезвоживания");
            Console.WriteLine("Введите время велопрогулки Натана (в часах): ");
            count = Convert.ToSingle(Console.ReadLine());
            count *= 0.5f;
            Console.WriteLine($"Натан нужно взять с собой на велопрогулку {Math.Floor(count)} литров воды.");

            Console.ReadKey();
        }
        static bool Love (int x, int y)
        {
            if (x % 2 == 0 ^ y % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
