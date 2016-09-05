using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public static class Diagram
    {
        static List<Actor> actors = new List<Actor>();
        static List<UseCase> useCases = new List<UseCase>();

        static int width;

        public static void Draw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for(int i = 0; i < actors.Count; i++)
            {
                actors[i].Draw(e, i);
            }
            for (int i = 0; i < useCases.Count; i++)
            {
                useCases[i].Draw(e, i);
            }
        }

        public static void Add(Object o)
        {
            if(o.GetType() == typeof(Actor))
            {
                actors.Add((Actor)o);
            } else if (o.GetType() == typeof(UseCase))
            {
                useCases.Add((UseCase)o);
            }
        }

        public static int Height
        {
            get
            {
                return new[] { actors.Count * 140, useCases.Count * 70 + 20 }.Max();
            }
        }

        public static int Width
        {
            set
            {
                width = value;
            }
        }

        public static List<Actor> Actors
        {
            get
            {
                return actors;
            }

            set
            {
                actors = value;
            }
        }

        public static List<UseCase> UseCases
        {
            get
            {
                return useCases;
            }

            set
            {
                useCases = value;
            }
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

            for (int i = 0; i < useCases.Count; i++)
            {
                Object userCase = useCases[i];
                if (userCase.X < coordinates.X && coordinates.X < userCase.X + userCase.Width && userCase.Y < coordinates.Y && coordinates.Y < userCase.Y + userCase.Height)
                {
                    return userCase;
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
            void MoveUp();
            void MoveDown();
            void Remove();
        }

        public class Actor : Object
        {
            int x = 0;
            int y = 0;
            int width = 100;
            int height = 140;
            string name = "Actor";
            Color color = Color.Black;
            int margin = 20;
            Font font = new Font("Segoe UI", 12);
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

                var actorHeight = height - 2 * margin;

                int stringWidth = (int)e.Graphics.MeasureString(name.Trim(), font).Width;

                if(stringWidth > 100)
                {
                    width = stringWidth;
                } else
                {
                    width = 100;
                }

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
                e.Graphics.DrawString(name, font, new SolidBrush(color), width / 2, y + actorHeight + 20, stringFormat);
            }

            public void MoveUp()
            {
                int index = actors.IndexOf(this);
                if (index > 0)
                {
                    actors.RemoveAt(index);
                    actors.Insert(index - 1, this);
                }
            }

            public void MoveDown()
            {
                int index = actors.IndexOf(this);
                if (index < actors.Count - 1)
                {
                    actors.RemoveAt(index);
                    actors.Insert(index + 1, this);
                }
            }

            public void Remove()
            {
                int index = actors.IndexOf(this);
                actors.RemoveAt(index);
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
        public class UseCase : Object
        {
            int x = 0;
            int y = 0;
            int width;
            int height = 30;
            string name = "Use Case";
            Color color = Color.Black;
            Font font = new Font("Segoe UI", 12);
            StringFormat stringFormat = new StringFormat();
            List<Actor> actors = new List<Actor>();
            string summary;
            string assuming;
            string description;
            string exceptions;
            string result;

            public UseCase()
            {

                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
            }

            public void Draw(PaintEventArgs e, int position)
            {
                width = (int)e.Graphics.MeasureString(name.Trim(), font).Width + 60;

                //Set coordinates
                x = Diagram.width - width - 20;
                y = (height + 40) * position + 20;


                //Pen
                Pen pen = new Pen(color, 1);

                //Draw ellipse
                Rectangle ellipse = new Rectangle(x, y, width, height);
                e.Graphics.DrawEllipse(pen, ellipse);

                //Name
                e.Graphics.DrawString(name, font, new SolidBrush(color), x + width / 2, y + height / 2, stringFormat);

                foreach(Actor actor in actors)
                {
                    e.Graphics.DrawLine(pen, new Point(actor.X + actor.Width, actor.Y + actor.Height / 2), new Point(x, y + height / 2));
                }
            }

            public void MoveUp()
            {
                int index = useCases.IndexOf(this);
                if (index > 0)
                {
                    useCases.RemoveAt(index);
                    useCases.Insert(index - 1, this);
                }
            }

            public void MoveDown()
            {
                int index = useCases.IndexOf(this);
                if (index < useCases.Count - 1)
                {
                    useCases.RemoveAt(index);
                    useCases.Insert(index + 1, this);
                }
            }

            public void Remove()
            {
                int index = useCases.IndexOf(this);
                useCases.RemoveAt(index);
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

            public List<Actor> Actors
            {
                get
                {
                    return actors;
                }

                set
                {
                    actors = value;
                }
            }

            public string Assuming
            {
                get
                {
                    return assuming;
                }

                set
                {
                    assuming = value;
                }
            }

            public string Summary
            {
                get
                {
                    return summary;
                }

                set
                {
                    summary = value;
                }
            }

            public string Exceptions
            {
                get
                {
                    return exceptions;
                }

                set
                {
                    exceptions = value;
                }
            }

            public string Result
            {
                get
                {
                    return result;
                }

                set
                {
                    result = value;
                }
            }

            public string Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }
        }
    }
}
