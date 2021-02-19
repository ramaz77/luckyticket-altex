using System;
using System.Linq;

namespace LuckyTicketTask
{
    class Program
    {
        // Метод для перевірки щасливості числа
        static bool IsLuckyTicket(string ticket)
        {
            // Оголошення змінних
            int ticketHalfLength = ticket.Length / 2;

            int firstPartSum = 0;
            int secondPartSum = 0;

            for (int i = 0; i < ticketHalfLength; i++)
            {
                firstPartSum += Int32.Parse(ticket[i].ToString());
            }

            for (int i = ticketHalfLength; i < ticket.Length; i++)
            {
                secondPartSum += Int32.Parse(ticket[i].ToString());
            }

            return firstPartSum == secondPartSum;
        }

        static void Main(string[] args)
        {
            // Оголошення змінних
            string inputStr;

            // Цикл
            while (true)
            {
                Console.WriteLine("Введіть число, що складається з 4-8 цифр:");

                inputStr = Console.ReadLine();

                // Перевірка коректності вводу
                if(!Int32.TryParse(inputStr, out int res) || inputStr.Length < 4 || inputStr.Length > 8)
                {
                    Console.WriteLine("Некорректна спроба.");
                    continue;
                }

                // Перевірка парності числа
                if(inputStr.Length % 2 != 0)
                {
                    inputStr = "0" + inputStr;
                }

                // Перевірка щасливості квитка
                if(IsLuckyTicket(inputStr))
                {
                    Console.WriteLine($"Вітаємо, Ваш квиток {inputStr} - щасливий!");
                }
                else
                {
                    Console.WriteLine($"Нажаль, Ваш квиток {inputStr} не був щасливим...");
                }

                // Пустий рядок для нової спроби
                Console.WriteLine();
            }
        }
    }
}
