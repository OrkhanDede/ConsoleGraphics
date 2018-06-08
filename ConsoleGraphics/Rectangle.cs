using System;
using System.Drawing;

namespace ConsoleGraphic
{
    class Rectangle
    {
        public Rectangle() { }
        public Rectangle(int xBound, int yBound)
        {
            this.XBound = xBound;
            this.YBound = yBound;
        }
        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.CursorTop = Y;
            Console.CursorLeft = X;
            TopDraw();
            VerticalDraw();
            BottomDraw();
        }
        public void TopDraw()
        {
            for (int i = 0; i < Width; i++)
            {
                if (i == 0)
                {
                    Console.Write(CharSet.LEFTUPCORNER);
                }
                else if (i == Width - 1)
                {
                    Console.Write(CharSet.RIGHTUPCORNER);
                }
                else
                    Console.Write(CharSet.EQUAL);
            }

            Console.WriteLine();
        }
        public void VerticalDraw()
        {
            string bosluk = "";

            for (int i = 1; i < Width - 1; i++)
            {
                bosluk += " ";
            }

            for (int i = 0; i < Height; i++)
            {
                Console.CursorLeft = X;
                Console.WriteLine(CharSet.VERTICAL + bosluk + CharSet.VERTICAL);
            }
        }
        public void BottomDraw()
        {
            Console.CursorLeft = X;
            for (int i = 0; i < Width; i++)
            {
                if (i == 0)
                {
                    Console.Write(CharSet.LEFTBOTTOMCORNER);
                }
                else if (i == Width - 1)
                {
                    Console.Write(CharSet.RIGHTBOTTOMCORNER);
                }
                else
                {
                    Console.Write(CharSet.EQUAL);
                }
            }
            Console.WriteLine();
        }
        public void SetLocation(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }



        public Point GetLocation() { return new Point(X, Y); }
        public int GetWidth() { return Width; }
        public int GetHeight() { return Height; }
        public ConsoleColor GetColor() { return Color; }

        public void SetSize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public void SetColor(ConsoleColor renk)
        {
            this.Color = renk;
        }
        public void ShiftToLeft()
        {
            if (X > 1)
            {
                X = X - 1;
            }
            SetLocation(X, Y);
        }
        public void ShiftToRight()
        {
            if (X + Width < XBound - 1)
            {
                X = X + 1;
            }
            SetLocation(X, Y);
        }
        public void ShiftToUp()
        {
            if (Y > 1)
            {
                Y = Y - 1;
            }
            SetLocation(X, Y);
        }
        public void ShiftToDown()
        {
            if (Y + Height < YBound - 1)
            {
                Y = Y + 1;
            }
            SetLocation(X, Y);
        }


        private int Width;
        private int Height;
        private ConsoleColor Color;
        protected int X;
        protected int Y;
        private int XBound;
        private int YBound;
    }
}
