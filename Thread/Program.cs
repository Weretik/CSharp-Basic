using System;
using System.Threading;

class Program
{

    /*
     * Завдання 1

        Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
        Створіть програму, яка виводитиме на екран ланцюжки падаючих символів. 
        Довжина кожного ланцюжка визначається випадково. Перший символ ланцюжка – білий, другий символ – світло-зелений, решта символів темно-зелені.
        ід час падіння ланцюжка на кожному кроці всі символи змінюють своє значення. Дійшовши до кінця, ланцюжок зникає і зверху формується новий ланцюжок.
        Дивіться example1.png представлений як зразок.

      * Завдання 2

        Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
        Розширте завдання 2 так, щоб в одному стовпці одночасно могло бути два ланцюжки символів. 
        Дивіться example2.png, представлений як зразок.
    */
    static Random random = new Random();
    static int width, height;
    static char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
    static Column[] columns;

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.CursorVisible = false;
        width = Console.WindowWidth;
        height = Console.WindowHeight;
        columns = new Column[width];

        for (int i = 0; i < width; i++)
        {
            columns[i] = new Column(i);
            new Thread(columns[i].FallLoop).Start();
        }
    }

    class Column
    {
        int length1, position1, delay1;
        int length2, position2, delay2;
        int columnIndex;
        char[] symbols1, symbols2;

        public Column(int index)
        {
            columnIndex = index;
            Reset();
            delay1 = random.Next(height);
            delay2 = random.Next(height);
        }

        public void Reset()
        {
            length1 = random.Next(6, 11);
            position1 = -length1;
            symbols1 = new char[length1];

            length2 = random.Next(6, 11);
            position2 = -length2 - random.Next(height / 2);
            symbols2 = new char[length2];

            for (int i = 0; i < length1; i++)
                symbols1[i] = RandomChar();
            for (int i = 0; i < length2; i++)
                symbols2[i] = RandomChar();
        }

        public void FallLoop()
        {
            Thread.Sleep(delay1 * 50);
            while (true)
            {
                Fall(ref position1, length1, symbols1);
                Thread.Sleep(50);
                Fall(ref position2, length2, symbols2);
                Thread.Sleep(50);
            }
        }

        public void Fall(ref int position, int length, char[] symbols)
        {
            if (position - length >= height)
            {
                ClearColumn();
                position = -length - random.Next(height / 2);
                for (int i = 0; i < length; i++)
                    symbols[i] = RandomChar();
                return;
            }

            lock (Console.Out)
            {
                if (position - length >= 0)
                {
                    Console.SetCursorPosition(columnIndex, position - length);
                    Console.Write(" ");
                }

                for (int i = 0; i < length; i++)
                {
                    int y = position - i;
                    if (y >= 0 && y < height)
                    {
                        Console.SetCursorPosition(columnIndex, y);
                        Console.ForegroundColor = i == 0 ? ConsoleColor.White : i == 1 ? ConsoleColor.Green : ConsoleColor.DarkGreen;
                        Console.Write(symbols[i]);
                    }
                    symbols[i] = RandomChar();
                }
            }
            position++;
        }

        private void ClearColumn()
        {
            lock (Console.Out)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.SetCursorPosition(columnIndex, y);
                    Console.Write(" ");
                }
            }
        }

        private char RandomChar()
        {
            return chars[random.Next(chars.Length)];
        }
    }


}
