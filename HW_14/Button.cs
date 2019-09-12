using System;

namespace HW_14
{
    public class Button
    {
        public string Text { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor Color { get; set; }
        public char Symbol { get; set; }
        public event Action _clickDelegate;

        public void Show(int sizeUp = 0)
        {
            Height += sizeUp;
            Width += sizeUp;
            Console.BackgroundColor = Color;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (IsBorder(i,j))
                    {
                        Console.Write(Symbol);
                    }
                    else if (IsPlaceForText(i,j))
                    {
                        j += Text.Length - 1;
                        Console.Write(Text);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Height -= sizeUp;
            Width -= sizeUp;
        }

        public void ClickButton()
        {
            Show(2);
            _clickDelegate?.Invoke();
        }

        private bool IsPlaceForText(int i, int j)
        {
            return (j == Width / 2 - Text.Length / 2 && i == Height / 2);
        }

        private bool IsBorder(int i, int j)
        {
            return (i == 0 || i == Height - 1) || (j == 0 || j == Width - 1);
        }
    }
}
