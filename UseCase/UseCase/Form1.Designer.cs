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
            this.addUseCase = new System.Windows.Forms.Button();
            this.saveToImage = new System.Windows.Forms.Button();
            this.actions = new System.Windows.Forms.FlowLayoutPanel();
            this.name = new System.Windows.Forms.TextBox();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.saveDiagramDialog = new System.Windows.Forms.SaveFileDialog();
            this.diagramWrapper = new System.Windows.Forms.Panel();
            this.properties = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.actions.SuspendLayout();
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
            this.diagram.Click += new System.EventHandler(this.diagram_Click);
            this.diagram.Paint += new System.Windows.Forms.PaintEventHandler(this.diagram_Paint);
            this.diagram.Resize += new System.EventHandler(this.diagram_Resize);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addActor);
            this.flowLayoutPanel1.Controls.Add(this.addUseCase);
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
            // addUseCase
            // 
            this.addUseCase.AutoSize = true;
            this.addUseCase.FlatAppearance.BorderSize = 0;
            this.addUseCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUseCase.Location = new System.Drawing.Point(156, 0);
            this.addUseCase.Margin = new System.Windows.Forms.Padding(0);
            this.addUseCase.MinimumSize = new System.Drawing.Size(0, 100);
            this.addUseCase.Name = "addUseCase";
            this.addUseCase.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.addUseCase.Size = new System.Drawing.Size(200, 100);
            this.addUseCase.TabIndex = 2;
            this.addUseCase.Text = "Add Use Case";
            this.addUseCase.UseVisualStyleBackColor = true;
            this.addUseCase.Click += new System.EventHandler(this.addUseCase_Click);
            // 
            // saveToImage
            // 
            this.saveToImage.AutoSize = true;
            this.saveToImage.FlatAppearance.BorderSize = 0;
            this.saveToImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToImage.Location = new System.Drawing.Point(356, 0);
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
            // actions
            // 
            this.actions.Controls.Add(this.name);
            this.actions.Controls.Add(this.properties);
            this.actions.Controls.Add(this.moveUp);
            this.actions.Controls.Add(this.moveDown);
            this.actions.Controls.Add(this.remove);
            this.actions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actions.Location = new System.Drawing.Point(0, 888);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(1269, 100);
            this.actions.TabIndex = 0;
            this.actions.Visible = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(30, 30);
            this.name.Margin = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.name.MaxLength = 32;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(320, 31);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // moveUp
            // 
            this.moveUp.AutoSize = true;
            this.moveUp.FlatAppearance.BorderSize = 0;
            this.moveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveUp.Location = new System.Drawing.Point(540, 0);
            this.moveUp.Margin = new System.Windows.Forms.Padding(0);
            this.moveUp.MinimumSize = new System.Drawing.Size(0, 100);
            this.moveUp.Name = "moveUp";
            this.moveUp.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.moveUp.Size = new System.Drawing.Size(148, 100);
            this.moveUp.TabIndex = 1;
            this.moveUp.Text = "Move Up";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.AutoSize = true;
            this.moveDown.FlatAppearance.BorderSize = 0;
            this.moveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveDown.Location = new System.Drawing.Point(688, 0);
            this.moveDown.Margin = new System.Windows.Forms.Padding(0);
            this.moveDown.MinimumSize = new System.Drawing.Size(0, 100);
            this.moveDown.Name = "moveDown";
            this.moveDown.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.moveDown.Size = new System.Drawing.Size(175, 100);
            this.moveDown.TabIndex = 2;
            this.moveDown.Text = "Move Down";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // remove
            // 
            this.remove.AutoSize = true;
            this.remove.FlatAppearance.BorderSize = 0;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Location = new System.Drawing.Point(863, 0);
            this.remove.Margin = new System.Windows.Forms.Padding(0);
            this.remove.MinimumSize = new System.Drawing.Size(0, 100);
            this.remove.Name = "remove";
            this.remove.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.remove.Size = new System.Drawing.Size(141, 100);
            this.remove.TabIndex = 3;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // saveDiagramDialog
            // 
            this.saveDiagramDialog.Filter = "Image (*.jpg)|*.jpg";
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
            // properties
            // 
            this.properties.AutoSize = true;
            this.properties.FlatAppearance.BorderSize = 0;
            this.properties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.properties.Location = new System.Drawing.Point(380, 0);
            this.properties.Margin = new System.Windows.Forms.Padding(0);
            this.properties.MinimumSize = new System.Drawing.Size(0, 100);
            this.properties.Name = "properties";
            this.properties.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.properties.Size = new System.Drawing.Size(160, 100);
            this.properties.TabIndex = 4;
            this.properties.Text = "Properties";
            this.properties.UseVisualStyleBackColor = true;
            this.properties.Click += new System.EventHandler(this.properties_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 988);
            this.Controls.Add(this.diagramWrapper);
            this.Controls.Add(this.actions);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.actions.ResumeLayout(false);
            this.actions.PerformLayout();
            this.diagramWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox diagram;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addActor;
        private System.Windows.Forms.FlowLayoutPanel actions;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.SaveFileDialog saveDiagramDialog;
        private System.Windows.Forms.Button saveToImage;
        private System.Windows.Forms.Panel diagramWrapper;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button addUseCase;
        private System.Windows.Forms.Button properties;
    }
}

