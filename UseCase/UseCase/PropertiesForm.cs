using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class PropertiesForm : Form
    {
        Diagram.UseCase useCase;
        PictureBox diagram;

        List<Diagram.Actor> actors;
        List<Diagram.Actor> actorsComboBox;
        public PropertiesForm(Diagram.UseCase useCase, PictureBox diagram)
        {
            this.useCase = useCase;
            this.diagram = diagram;
            InitializeComponent();
            actors = useCase.Actors;
            foreach (Diagram.Actor actor in actors)
            {
                ActorLabel actorLabel = new ActorLabel();
                actorLabel.Text = actor.Name;
                actorLabel.Tag = actor;
                actorLabel.Click += new EventHandler(actorLabel_Click);
                actorsBox.Controls.Add(actorLabel);
            }
            updateComboBox();
            useCaseName.Text = useCase.Name;
            useCaseSummary.Text = useCase.Summary;
            useCaseAssuming.Text = useCase.Assuming;
            useCaseDescription.Text = useCase.Description;
            useCaseExceptions.Text = useCase.Exceptions;
            useCaseResult.Text = useCase.Result;

        }

        void updateComboBox()
        {
            comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
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
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            useCase.Actors = actors;
            diagram.Invalidate();
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

        private void useCaseName_TextChanged(object sender, EventArgs e)
        {
            useCase.Name = useCaseName.Text;
            diagram.Invalidate();
        }

        private void useCaseSummary_TextChanged(object sender, EventArgs e)
        {
            useCase.Summary = useCaseSummary.Text;
            diagram.Invalidate();
        }

        private void useCaseExceptions_TextChanged(object sender, EventArgs e)
        {
            useCase.Exceptions = useCaseExceptions.Text;
            diagram.Invalidate();
        }

        private void useCaseResult_TextChanged(object sender, EventArgs e)
        {
            useCase.Result = useCaseResult.Text;
            diagram.Invalidate();
        }

        private void useCaseAssuming_TextChanged(object sender, EventArgs e)
        {
            useCase.Assuming = useCaseAssuming.Text;
            diagram.Invalidate();
        }

        private void useCaseDescription_TextChanged(object sender, EventArgs e)
        {
            useCase.Description = useCaseDescription.Text;
            diagram.Invalidate();
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
