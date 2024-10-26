using System.Numerics;
using System.Text;
using System.Globalization;
using System;

namespace HomeWorkC__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;


            /*Task 1
            Console.WriteLine("Введіть число в діапазоні від 1 до 100");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 100)
            {
                Console.WriteLine("Ви ввели некоректне число");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }*/


           /*Task 2
            Console.WriteLine("Введіть число від якого ви хочете знайти відсоток");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть відсоток який ви хочете знайти від даного числа");
            double percent = double.Parse(Console.ReadLine());

            Console.WriteLine($"{percent}% від числа {number} == {number * percent / 100}");*/





            /*Task 3
            Console.WriteLine("Введіть числа через пробіл");

            string input = Console.ReadLine();
            string result = "";

            int[] number = input.Split(' ').Select(int.Parse).ToArray();

            foreach (int i in number)
            {
                result += i;
            }
            Console.WriteLine(result);*/






            /*Task 4
            Console.WriteLine("Введіть шестизначе число");

            string input = Console.ReadLine();
            char[] digits = input.ToCharArray();

            if (input.Length != 6)
            {
                Console.WriteLine("Помилка: введіть шестизначне число.");
                return;
            }

            Console.WriteLine("Введіть перший номер розряду");
            int firstIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Введіть другий номер розряду");
            int secondIndex = int.Parse(Console.ReadLine()) - 1;

            char temp = digits[firstIndex];
            digits[firstIndex] = digits[secondIndex];
            digits[secondIndex] = temp;

            string result = new string(digits);
            Console.WriteLine($"До: {input}\nПісля: {result}");*/








            /* Task 5
            Console.WriteLine("Введіть дату у форматі dd.MM.yyyy:");
            string input = Console.ReadLine();


            DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            string season = GetSeason(date);
            string dayOfWeek = date.ToString("dddd", CultureInfo.InvariantCulture);

            Console.WriteLine($"{season} {dayOfWeek}");*/



            /*Task 6
            Console.WriteLine("Введіть показання температури:");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Оберіть тип конвертації:");
            Console.WriteLine("1: Фаренгейт в Цельсій");
            Console.WriteLine("2: Цельсій в Фаренгейт");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                double celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine($"Температура в Цельсіях: {celsius:F2} °C");
            }
            else if (choice == 2)
            {
                double fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit:F2} °F");
            }
            else
            {
                Console.WriteLine("Помилка: неправильний вибір.");
            }*/




            /*Task 7
            Console.WriteLine("Введіть перше число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int num2 = int.Parse(Console.ReadLine());

            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);

            Console.WriteLine($"Парні числа у діапазоні від {start} до {end}:");

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/
        }

        /* Task 5
         static string GetSeason(DateTime date)
        {
            int month = date.Month;
            int day = date.Day;

            if ((month == 12 && day >= 21) || month == 1 || month == 2 || (month == 3 && day < 21))
                return "Winter";
            else if ((month == 3 && day >= 21) || month == 4 || month == 5 || (month == 6 && day < 21))
                return "Spring";
            else if ((month == 6 && day >= 21) || month == 7 || month == 8 || (month == 9 && day < 23))
                return "Summer";
            else
                return "Autumn";
        }*/





    }
}
