using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCase
{
    static class UseCase
    {
        static List<Object> objects = new List<Object>();

        public static void Draw(PaintEventArgs e)
        {
            foreach(Object o in objects)
            {
                o.Draw(e);
            }
            /*
            */
        }

        public static void Add(Object o)
        {
            objects.Add(o);
        }

        public interface Object
        {
            void Draw(PaintEventArgs e);
        }

        public class Actor : Object
        {
            int x;
            int y;
            int width;
            int height;

            public Actor(int x = 0, int y = 0)
            {
                this.X = x;
                this.Y = y;
            }
            public void Draw(PaintEventArgs e)
            {
                //Drawn actor
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Rectangle rectangle = new Rectangle(50, 100, 150, 150);
                e.Graphics.DrawEllipse(Pens.Black, rectangle);
                e.Graphics.DrawRectangle(Pens.Red, rectangle);
            }

            public int X
            {
                get
                {
                    return x;
                }

                set
                {
                    x = value;
                }
            }

            public int Y
            {
                get
                {
                    return y;
                }

                set
                {
                    y = value;
                }
            }

            public int Width
            {
                get
                {
                    return width;
                }

                set
                {
                    width = value;
                }
            }

            public int Height
            {
                get
                {
                    return height;
                }

                set
                {
                    height = value;
                }
            }
        }
    }
}
