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
            this.diagram = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addActor = new System.Windows.Forms.Button();
            this.actorActions = new System.Windows.Forms.FlowLayoutPanel();
            this.actorName = new System.Windows.Forms.TextBox();
            this.saveDiagramDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveToImage = new System.Windows.Forms.Button();
            this.diagramWrapper = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.actorActions.SuspendLayout();
            this.diagramWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagram
            // 
            this.diagram.BackColor = System.Drawing.Color.White;
            this.diagram.Dock = System.Windows.Forms.DockStyle.Top;
            this.diagram.Location = new System.Drawing.Point(0, 0);
            this.diagram.Margin = new System.Windows.Forms.Padding(0);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(1269, 0);
            this.diagram.TabIndex = 0;
            this.diagram.TabStop = false;
            this.diagram.Paint += new System.Windows.Forms.PaintEventHandler(this.diagram_Paint);
            this.diagram.Resize += new System.EventHandler(this.diagram_Resize);
            this.diagram.Click += new System.EventHandler(this.diagram_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addActor);
            this.flowLayoutPanel1.Controls.Add(this.saveToImage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1269, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // addActor
            // 
            this.addActor.AutoSize = true;
            this.addActor.FlatAppearance.BorderSize = 0;
            this.addActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActor.Location = new System.Drawing.Point(0, 0);
            this.addActor.Margin = new System.Windows.Forms.Padding(0);
            this.addActor.MinimumSize = new System.Drawing.Size(0, 100);
            this.addActor.Name = "addActor";
            this.addActor.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.addActor.Size = new System.Drawing.Size(156, 100);
            this.addActor.TabIndex = 0;
            this.addActor.Text = "Add Actor";
            this.addActor.UseVisualStyleBackColor = true;
            this.addActor.Click += new System.EventHandler(this.addActor_Click);
            // 
            // actorActions
            // 
            this.actorActions.Controls.Add(this.actorName);
            this.actorActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actorActions.Location = new System.Drawing.Point(0, 888);
            this.actorActions.Name = "actorActions";
            this.actorActions.Size = new System.Drawing.Size(1269, 100);
            this.actorActions.TabIndex = 0;
            this.actorActions.Visible = false;
            // 
            // actorName
            // 
            this.actorName.Location = new System.Drawing.Point(30, 30);
            this.actorName.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.actorName.MaxLength = 32;
            this.actorName.Name = "actorName";
            this.actorName.Size = new System.Drawing.Size(320, 31);
            this.actorName.TabIndex = 0;
            this.actorName.TextChanged += new System.EventHandler(this.actorName_TextChanged);
            // 
            // saveDiagramDialog
            // 
            this.saveDiagramDialog.Filter = "Image (*.jpg)|*.jpg";
            // 
            // saveToImage
            // 
            this.saveToImage.AutoSize = true;
            this.saveToImage.FlatAppearance.BorderSize = 0;
            this.saveToImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToImage.Location = new System.Drawing.Point(156, 0);
            this.saveToImage.Margin = new System.Windows.Forms.Padding(0);
            this.saveToImage.MinimumSize = new System.Drawing.Size(0, 100);
            this.saveToImage.Name = "saveToImage";
            this.saveToImage.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.saveToImage.Size = new System.Drawing.Size(188, 100);
            this.saveToImage.TabIndex = 1;
            this.saveToImage.Text = "Export Image";
            this.saveToImage.UseVisualStyleBackColor = true;
            this.saveToImage.Click += new System.EventHandler(this.saveToImage_Click);
            // 
            // diagramWrapper
            // 
            this.diagramWrapper.AutoScroll = true;
            this.diagramWrapper.BackColor = System.Drawing.Color.White;
            this.diagramWrapper.Controls.Add(this.diagram);
            this.diagramWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramWrapper.Location = new System.Drawing.Point(0, 100);
            this.diagramWrapper.Name = "diagramWrapper";
            this.diagramWrapper.Size = new System.Drawing.Size(1269, 788);
            this.diagramWrapper.TabIndex = 2;
            this.diagramWrapper.Click += new System.EventHandler(this.diagram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 988);
            this.Controls.Add(this.diagramWrapper);
            this.Controls.Add(this.actorActions);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.actorActions.ResumeLayout(false);
            this.actorActions.PerformLayout();
            this.diagramWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox diagram;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addActor;
        private System.Windows.Forms.FlowLayoutPanel actorActions;
        private System.Windows.Forms.TextBox actorName;
        private System.Windows.Forms.SaveFileDialog saveDiagramDialog;
        private System.Windows.Forms.Button saveToImage;
        private System.Windows.Forms.Panel diagramWrapper;
    }
}

