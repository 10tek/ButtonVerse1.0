using System;
using System.Collections.Generic;
using System.Threading;

namespace HW_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var buttonQ = new Button
            {
                Color = ConsoleColor.DarkBlue,
                Height = 4,
                Width = 20,
                Text = "Random Symbol",
                Symbol = '#'
            };
            var buttonW = new Button
            {
                Color = ConsoleColor.DarkGreen,
                Height = 4,
                Width = 20,
                Text = "Laught",
                Symbol = '$'
            };
            var buttonE = new Button
            {
                Color = ConsoleColor.DarkRed,
                Height = 4,
                Width = 20,
                Text = "Random Color",
                Symbol = '%'
            };
            var buttonR = new Button
            {
                Color = ConsoleColor.DarkYellow,
                Height = 4,
                Width = 20,
                Text = "Random Number",
                Symbol = '&'
            };

            var buttons = new List<Button>();
            buttons.Add(buttonQ);
            buttons.Add(buttonW);
            buttons.Add(buttonE);
            buttons.Add(buttonR);

            buttons[0]._clickDelegate += ShowSymbol;
            buttons[1]._clickDelegate += ShowText;
            buttons[2]._clickDelegate += ShowColor;
            buttons[3]._clickDelegate += ShowNumber;

            while (true)
            {
                foreach (var item in buttons)
                {
                    item.Show();
                }
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    foreach (var item in buttons)
                    {
                        item.ClickButton();
                    }
                    Thread.Sleep(1000);
                }
                Console.Clear();
            }
        }

        private static void ShowSymbol()
        {
            Random random = new Random();
            switch (random.Next(0, 4))
            {
                case 0: Console.WriteLine("$"); break;
                case 1: Console.WriteLine("%"); break;
                case 2: Console.WriteLine("&"); break;
                case 3: Console.WriteLine("*"); break;
            }
        }

        private static void ShowText()
        {
            Random random = new Random();
            switch (random.Next(0, 4))
            {
                case 0: Console.WriteLine("HEHE"); break;
                case 1: Console.WriteLine("HOHO"); break;
                case 2: Console.WriteLine("HAHA"); break;
                case 3: Console.WriteLine("HYHY"); break;
            }
        }

        private static void ShowColor()
        {
            Random random = new Random();
            switch (random.Next(0, 4))
            {
                case 0: Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("      "); break;
                case 1: Console.BackgroundColor = ConsoleColor.Yellow; Console.WriteLine("      "); break;
                case 2: Console.BackgroundColor = ConsoleColor.White; Console.WriteLine("      "); break;
                case 3: Console.BackgroundColor = ConsoleColor.Blue; Console.WriteLine("      "); break;
            }
            Console.ResetColor();
        }

        private static void ShowNumber()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(0, 10));
        }
    }
}