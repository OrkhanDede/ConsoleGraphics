using System;
namespace ConsoleGraphic
{
    class ControlPanel
    {
        public ControlPanel(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            DrawingArea = new Rectangle();

            DrawingArea.SetSize(width, height);
            DrawingArea.SetColor(ConsoleColor.Yellow);
        }

        public void Draw()
        {
            DrawingArea.Draw();
            MenuDraw();
        }
        public void SetLocation(int x, int y)
        {
            this.X = x;
            this.Y = y;
            DrawingArea.SetLocation(x, y);
        }

        public void MenuDraw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = Y + 1;
            Console.CursorLeft = X + 12;
            Console.WriteLine("CONTROL PANEL");
            Console.CursorTop = Y + 4;
            Console.CursorLeft = X + 10;
            Console.WriteLine("ADD PICTURE       <E>\n");
            Console.CursorTop = Y + 7;
            Console.CursorLeft = X + 10;
            Console.WriteLine("SHIFT TO LEFT     <A>\n");
            Console.CursorTop = Y + 10;
            Console.CursorLeft = X + 10;
            Console.WriteLine("SHIFT TO RIGHT    <D>\n");
            Console.CursorTop = Y + 13;
            Console.CursorLeft = X + 10;
            Console.WriteLine("SHIFT TO UP       <W>\n");
            Console.CursorTop = Y + 16;
            Console.CursorLeft = X + 10;
            Console.WriteLine("SHIFT TO BOTTOM   <S>\n");
        }


        private int Width;
        private int Height;
        private int X;
        private int Y;
        private Rectangle DrawingArea;
    }
}
