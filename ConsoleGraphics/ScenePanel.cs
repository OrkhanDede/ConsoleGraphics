using System;
namespace ConsoleGraphic
{
    class ScenePanel
    {
        public ScenePanel() { }

        public ScenePanel(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            DrawingArea = new Rectangle();
            DrawingArea.SetSize(width, height);
            DrawingArea.SetLocation(0, 0);
            DrawingArea.SetColor(ConsoleColor.DarkRed);
            PictureCount = 0;
            MaxPictureCount = 100;
            Pictures = new Rectangle[MaxPictureCount];
            ActivePicture = new Rectangle();
            ActivePicture.SetSize(width, height);
            ActivePicture.SetLocation(0, 0);
        }
        public void SetLocation(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Draw()
        {
            DrawingArea.Draw();
            if (Pictures != null)
            {
                for (int i = 0; i < PictureCount; i++)
                {
                    Pictures[i].Draw();
                }
            }
        }
        public void SetActivePicture(Rectangle newPicture)
        {
            newPicture.SetSize(RandomNumber.NumberGenerat(2, 20), RandomNumber.NumberGenerat(2, 10));
            newPicture.SetLocation(RandomNumber.NumberGenerat(5, 50), RandomNumber.NumberGenerat(5, 30));
            newPicture.SetColor((ConsoleColor)RandomNumber.NumberGenerat(1, 15));
            Pictures[PictureCount] = newPicture;
            PictureCount++;
            ActivePicture = newPicture;
        }
        public void PictureShiftToLeft()
        {
            ActivePicture.ShiftToLeft();
            Draw();
        }
        public bool PictureShiftToRight()
        {
            ActivePicture.ShiftToRight();

            Draw();
            return true;
        }
        public void PictureShiftToUp()
        {
            ActivePicture.ShiftToUp();
            Draw();
        }
        public void PictureShiftToDown()
        {
            ActivePicture.ShiftToDown();
            Draw();
        }
        public bool PicturesCarpisiyormu()
        {
            int rectangleX = ActivePicture.GetLocation().X;
            int rectangleY = ActivePicture.GetLocation().Y;
            int rectangleXBound = ActivePicture.GetWidth() + rectangleX;
            int rectangleYBound = ActivePicture.GetHeight() + rectangleY;

            int pictureX = 0;
            int pictureY = 0;
            int pictureXBound = 0;
            int pictureYBound = 0;
            for (int i = 0; i < PictureCount; i++)
            {
                if (Pictures[i] != ActivePicture)
                {
                    pictureX = Pictures[i].GetLocation().X;
                    pictureY = Pictures[i].GetLocation().Y;
                    pictureXBound = Pictures[i].GetLocation().X + Pictures[i].GetWidth();
                    pictureYBound = Pictures[i].GetLocation().Y + Pictures[i].GetHeight();
                    if (
                  (pictureXBound) >= (rectangleX) &&
                  (pictureX) <= (rectangleXBound) &&
                  (pictureYBound + 2) >= (rectangleY) &&
                  (pictureY - 2) <= (rectangleYBound)
                )
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        private int Width;
        private int Height;
        private int X;
        private int Y;
        private Rectangle DrawingArea;
        private Rectangle ActivePicture;
        private int PictureCount;
        private int MaxPictureCount;
        private Rectangle[] Pictures;


    }
}
