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
        static List<Actor> actors = new List<Actor>();

        public static void Draw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for(int i = 0; i < actors.Count; i++)
            {
                actors[i].Draw(e, i);
            }
        }

        public static void Add(Object o)
        {
            actors.Add((Actor)o);
        }
        
        public static Object getObject(Point coordinates)
        {
            for (int i = 0; i < actors.Count; i++)
            {
                Object actor = actors[i];
                if(actor.X < coordinates.X && coordinates.X < actor.X + actor.Width && actor.Y < coordinates.Y && coordinates.Y < actor.Y + actor.Height)
                {
                    return actor;
                }
            }
            return null;
        }

        public interface Object
        {
            void Draw(PaintEventArgs e, int position);
            int X { get; set; }
            int Y { get; set; }
            int Width { get; set; }
            int Height { get; set; }
            string Name { get; set; }
            Color Color { get; set; }
        }

        public class Actor : Object
        {
            int x = 0;
            int y = 0;
            int width = 80;
            int height = 80;
            string name;
            Color color = Color.Black;
            int margin = 10;
            Font font = new Font("Segoe UI", 8);
            StringFormat stringFormat = new StringFormat();

            public Actor()
            {

                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
            }

            public void Draw(PaintEventArgs e, int position)
            {
                //Set coordinates
                y = height * position;

                var actorHeight = height - 2 * margin - 10;

                //Pen
                Pen pen = new Pen(color, 1);

                //Draw head
                Rectangle head = new Rectangle(width / 2 - actorHeight / 6, margin + y, actorHeight / 3, actorHeight / 3);
                e.Graphics.DrawEllipse(pen, head);

                //Draw body
                Point bodyStart = new Point(width / 2, head.Y + head.Height);
                Point bodyEnd = new Point(bodyStart.X, bodyStart.Y + actorHeight / 3);
                e.Graphics.DrawLine(pen, bodyStart, bodyEnd);

                //Draw arms
                Point armsStart = new Point(head.X, bodyStart.Y + actorHeight / 6);
                Point armsEnd = new Point(head.X + head.Width, armsStart.Y);
                e.Graphics.DrawLine(pen, armsStart, armsEnd);

                //Draw legs
                Point legsStart = new Point(width / 2, bodyEnd.Y);
                e.Graphics.DrawLine(pen, legsStart, new Point(head.X, y + actorHeight));
                e.Graphics.DrawLine(pen, legsStart, new Point(head.X + head.Width, y + actorHeight));

                //Name
                e.Graphics.DrawString(name, font, new SolidBrush(Color.Black), width / 2, y + actorHeight + 10, stringFormat);
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

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public Color Color
            {
                get
                {
                    return color;
                }

                set
                {
                    color = value;
                }
            }
        }
    }
}
