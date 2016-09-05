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
    public partial class PropertiesForm : Form
    {
        List<Diagram.Actor> actors;
        List<Diagram.Actor> actorsComboBox;
        public PropertiesForm(Diagram.UseCase useCase)
        {
            InitializeComponent();
            actors = useCase.Actors;
            updateComboBox();
        }

        void updateComboBox()
        {
            comboBox1.SelectedIndexChanged -= new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            List<string> actorsName = new List<string>();
            actorsComboBox = new List<Diagram.Actor>();
            foreach (Diagram.Actor actor in Diagram.Actors)
            {
                if (!actors.Contains(actor))
                {
                    actorsComboBox.Add(actor);
                    actorsName.Add(actor.Name);
                }
            }
            comboBox1.DataSource = actorsName;
            if(actorsName.Count() > 0)
            {
                comboBox1.Show();
                button1.Show();
            } else
            {
                comboBox1.Hide();
                button1.Hide();
            }
            comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActorLabel actorLabel = new ActorLabel();
            actorLabel.Text = actorsComboBox[comboBox1.SelectedIndex].Name;
            actorLabel.Tag = actorsComboBox[comboBox1.SelectedIndex];
            actorLabel.Click += new EventHandler(actorLabel_Click);
            actorsBox.Controls.Add(actorLabel);
            actors.Add(actorsComboBox[comboBox1.SelectedIndex]);
            updateComboBox();
        }

        private void actorLabel_Click(object sender, EventArgs e)
        {
            ActorLabel actorLabel = (ActorLabel)sender;
            Diagram.Actor actor = (Diagram.Actor)actorLabel.Tag;
            actors.Remove(actor);
            actorsBox.Controls.Remove(actorLabel);
            updateComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }
    }

    public partial class ActorLabel : Label
    {
        int padding = 3;
        int margin = 5;
        public ActorLabel()
        {
            AutoSize = true;
            BackColor = Color.LightGray;
            Margin = new Padding(5, 5, 0, 0);
            Font = new Font("Segoe UI", 7);
            Padding = new Padding(padding, padding, Height + padding, padding);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(pen, new Point(Width - Height + margin, margin), new Point(Width - margin, Height - margin));
            e.Graphics.DrawLine(pen, new Point(Width - margin, margin), new Point(Width - Height + margin, Height - margin));
        }
    }
}
