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
        Diagram.Object focusedObject;
        public Form1()
        {
            InitializeComponent();
            Diagram.Width = diagram.Width;
        }

        private void diagram_Paint(object sender, PaintEventArgs e)
        {
            Diagram.Draw(e);
        }
        private void diagram_Resize(object sender, EventArgs e)
        {
            Diagram.Width = diagram.Width;
            diagram.Invalidate();
        }

        private void addActor_Click(object sender, EventArgs e)
        {
            Diagram.Actor actor = new Diagram.Actor();
            Diagram.Add(actor);
            diagram.Height = Diagram.Height;
            diagram.Invalidate();
        }

        private void diagram_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Diagram.Object o = Diagram.getObject(coordinates);
            diagram.Focus();
            if(focusedObject != null)
            {
                focusedObject.Color = Color.Black;
            }
            if (o != null && (!actions.Visible || o != focusedObject))
            {
                focusedObject = o;
                focusedObject.Color = Color.DarkCyan;
                name.Text = focusedObject.Name;
                actions.Show();
            } else
            {
                actions.Hide();
            }
            diagram.Invalidate();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            focusedObject.Name = name.Text;
            diagram.Invalidate();
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

        private void moveUp_Click(object sender, EventArgs e)
        {
            focusedObject.MoveUp();
            diagram.Invalidate();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            focusedObject.MoveDown();
            diagram.Invalidate();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            focusedObject.Remove();
            diagram.Height = Diagram.Height;
            diagram.Invalidate();
            actions.Hide();
        }

        private void addUseCase_Click(object sender, EventArgs e)
        {
            Diagram.UseCase useCase = new Diagram.UseCase();
            Diagram.Add(useCase);
            diagram.Height = Diagram.Height;
            diagram.Invalidate();

        }

        private void properties_Click(object sender, EventArgs e)
        {
            new PropertiesForm((Diagram.UseCase)focusedObject).ShowDialog();
        }
    }
}
