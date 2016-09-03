namespace UseCase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.diagram = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addActor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagram
            // 
            this.diagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram.Location = new System.Drawing.Point(0, 100);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(840, 699);
            this.diagram.TabIndex = 0;
            this.diagram.TabStop = false;
            this.diagram.Click += new System.EventHandler(this.diagram_Click);
            this.diagram.Paint += new System.Windows.Forms.PaintEventHandler(this.diagram_Paint);
            this.diagram.Resize += new System.EventHandler(this.diagram_Resize);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addActor);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(840, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // addActor
            // 
            this.addActor.AutoSize = true;
            this.addActor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActor.Location = new System.Drawing.Point(0, 0);
            this.addActor.Margin = new System.Windows.Forms.Padding(0);
            this.addActor.MinimumSize = new System.Drawing.Size(0, 100);
            this.addActor.Name = "addActor";
            this.addActor.Size = new System.Drawing.Size(118, 100);
            this.addActor.TabIndex = 0;
            this.addActor.Text = "Add Actor";
            this.addActor.UseVisualStyleBackColor = true;
            this.addActor.Click += new System.EventHandler(this.addActor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 799);
            this.Controls.Add(this.diagram);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox diagram;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addActor;
    }
}

