using System;
using System.Collections.Generic;
using System.Text;

namespace HW_14
{
    public class ButtonService
    {
        private List<Button> _buttons;
        public Button this[int index]
        {
            get { return _buttons[index]; }
            set { _buttons[index] = value; }
        }
        public ButtonService(List<Button> buttons)
        {
            _buttons = buttons;
        }
        public void ShowButtons()
        {
            foreach (var item in _buttons)
            {
                Console.ForegroundColor = item.Color;
                for (int i = 0; i < item.Height; i++)
                {
                    for (int j = 0; j < item.Width; j++)
                    {
                        if ((i == 0 || i == item.Height - 1) || (j == 0 || j == item.Width - 1))
                        {
                            Console.Write(item.Symbol);
                        }
                        else if (j == item.Width / 2 - item.Text.Length / 2 && i == item.Height / 2)
                        {
                            j += item.Text.Length - 1;
                            Console.Write(item.Text);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public void Click()
        {
            foreach (var item in _buttons)
            {
                item.ClickButton();
            }
        }
    }
}
