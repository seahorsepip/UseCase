using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            diagram.Invalidate();
        }

        private void diagram_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            UseCase.Object o = UseCase.getObject(coordinates);
            if(focusedObject != null)
            {
                focusedObject.Color = Color.Black;
            }
            if (o != null)
            {
                focusedObject = o;
                focusedObject.Color = Color.Red;
                //MessageBox.Show(o.Y.ToString());
            }
            diagram.Invalidate();
        }
    }
}
