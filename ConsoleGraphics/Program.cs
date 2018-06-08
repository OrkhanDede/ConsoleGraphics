using System;

namespace ConsoleGraphic
{
    class Program
    {
        static void Main(string[] args)
        {
            ScenePanel scene = new ScenePanel(70, 40);
            scene.SetLocation(0, 0);
            scene.Draw();

            ControlPanel control = new ControlPanel(38, 18);
            control.SetLocation(71, 0);
            control.Draw();

            InfoPanel info = new InfoPanel(38, 20);
            info.SetLocation(71, 20);
            info.Draw();

            int right= 0, left= 0, bottom = 0, up= 0;
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey();
                if (!scene.PicturesCarpisiyormu())
                {
                    right= 0;
                    left= 0;
                    bottom = 0;
                    up= 0;
                }
                switch (key.KeyChar.ToString().ToLower())
                {
                    case "w":
                        if (up== 0)
                        {
                            scene.PictureShiftToUp();
                            if (scene.PicturesCarpisiyormu())
                            {
                                if (right== 1 || left== 1)
                                {
                                    up= 0;
                                    bottom = 0;
                                }
                                else
                                {
                                    up= 1;
                                }
                            }
                        }

                        info.Draw();
                        info.infoDraw();
                        break;
                    case "d":
                        if (right== 0)
                        {
                            scene.PictureShiftToRight();
                            if (scene.PicturesCarpisiyormu())
                            {
                                if (up== 1 || bottom == 1)
                                {
                                    left= 0;
                                    right= 0;
                                }
                                else
                                {
                                    right= 1;
                                }
                            }
                        }
                        info.Draw();
                        info.infoDraw();
                        break;
                    case "a":
                        if (left== 0)
                        {
                            scene.PictureShiftToLeft();
                            if (scene.PicturesCarpisiyormu())
                            {
                                if (up== 1 || bottom == 1)
                                {
                                    left= 0;
                                    right= 0;
                                }
                                else
                                {
                                    left= 1;
                                }
                            }
                        }

                        info.Draw();
                        info.infoDraw();
                        break;
                    case "s":
                        if (bottom == 0)
                        {
                            scene.PictureShiftToDown();
                            if (scene.PicturesCarpisiyormu())
                            {
                                if (right== 1 || left== 1)
                                {
                                    up= 0;
                                    bottom = 0;
                                }
                                else
                                {
                                    bottom = 1;
                                }
                            }
                        }

                        info.Draw();
                        info.infoDraw();
                        break;
                    case "e":
                        Rectangle dortgen = new Rectangle(70, 40);
                        scene.SetActivePicture(dortgen);
                        scene.Draw();
                        if (scene.PicturesCarpisiyormu())
                        {
                            right= 1;
                            left= 1;
                            up= 1;
                            bottom = 1;
                        }
                        info.PictureAta(dortgen);
                        info.Draw();
                        info.infoDraw();
                        break;
                }
            }
        }
    }
}
