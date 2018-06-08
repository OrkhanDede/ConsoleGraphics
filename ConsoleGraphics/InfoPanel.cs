using System;
namespace ConsoleGraphic
{
    class InfoPanel
    {
        public InfoPanel(int width, int height)
        {
            this.width = width;
            this.height = height;
            DrawingArea = new Rectangle();
            DrawingArea.SetSize(width, height);
            DrawingArea.SetColor(ConsoleColor.DarkBlue);
            ActivePicture = new Rectangle();
        }

        public void SetLocation(int x, int y)
        {
            this.x = x;
            this.y = y;
            DrawingArea.SetLocation(x, y);
        }
        public void Draw()
        {
            DrawingArea.Draw();

        }
        public void infoDraw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = y + 4;
            Console.CursorLeft = x + 10;
            Console.WriteLine("X............: {0} \n", ActivePicture.GetLocation().X);
            Console.CursorTop = y + 7;
            Console.CursorLeft = x + 10;
            Console.WriteLine("Y............: {0}\n", ActivePicture.GetLocation().Y);
            Console.CursorTop = y + 10;
            Console.CursorLeft = x + 10;
            Console.WriteLine("Width.....: {0}\n", ActivePicture.GetWidth());
            Console.CursorTop = y + 13;
            Console.CursorLeft = x + 10;
            Console.WriteLine("Height....: {0}\n", ActivePicture.GetHeight());
            Console.CursorTop = y + 16;
            Console.CursorLeft = x + 10;
            Console.WriteLine("Color.........: {0}\n", ActivePicture.GetColor());
        }
        public void PictureAta(Rectangle sekil)
        {
            ActivePicture = sekil;
        }


        private Rectangle ActivePicture;
        private Rectangle DrawingArea;
        private int width;
        private int height;
        private int x;
        private int y;

    }
}
