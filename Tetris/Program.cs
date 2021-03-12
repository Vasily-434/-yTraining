using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40,30);
           //public int x1 = 2;
           //public int y1 = 3;
           //public char c1 = '*';

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 2;
            p1.c = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 3;
            p2.y = 4;
            p2.c = '*';
            p2.Draw();
        }
        static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
   
}
