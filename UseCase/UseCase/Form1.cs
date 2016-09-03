using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCase
{
    public partial class Form1 : Form
    {
        UseCase.Object focusedObject;
        public Form1()
        {
            InitializeComponent();
        }

        private void diagram_Paint(object sender, PaintEventArgs e)
        {
            UseCase.Draw(e);
        }
        private void diagram_Resize(object sender, EventArgs e)
        {
            diagram.Invalidate();
        }

        private void addActor_Click(object sender, EventArgs e)
        {
            UseCase.Actor actor = new UseCase.Actor();
            UseCase.Add(actor);
            diagram.Height = UseCase.Height;
            diagram.Invalidate();
        }

        private void diagram_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            UseCase.Object o = UseCase.getObject(coordinates);
            diagram.Focus();
            if(focusedObject != null)
            {
                focusedObject.Color = Color.Black;
            }
            if (o != null && (!actorActions.Visible || o != focusedObject))
            {
                focusedObject = o;
                focusedObject.Color = Color.DarkCyan;
                actorName.Text = focusedObject.Name;
                actorActions.Show();
            } else
            {
                actorActions.Hide();
            }
            diagram.Invalidate();
        }

        private void actorName_TextChanged(object sender, EventArgs e)
        {
            if(focusedObject != null)
            {
                focusedObject.Name = actorName.Text;
                diagram.Invalidate();
            }
        }

        private void saveToImage_Click(object sender, EventArgs e)
        {
            if (saveDiagramDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(diagram.Width, diagram.Height);
                diagram.DrawToBitmap(bmp, new Rectangle(0, 0, diagram.Width, diagram.Height));
                bmp.Save(saveDiagramDialog.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
