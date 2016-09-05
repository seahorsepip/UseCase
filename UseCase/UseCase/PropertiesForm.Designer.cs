namespace UseCaseHelper
{
    partial class PropertiesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.useCaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.useCaseSummary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.actorsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.useCaseAssuming = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.useCaseDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.useCaseExceptions = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.useCaseResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.useCaseName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 56);
            this.panel1.TabIndex = 0;
            // 
            // useCaseName
            // 
            this.useCaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useCaseName.Location = new System.Drawing.Point(140, 0);
            this.useCaseName.Name = "useCaseName";
            this.useCaseName.Size = new System.Drawing.Size(401, 31);
            this.useCaseName.TabIndex = 1;
            this.useCaseName.TextChanged += new System.EventHandler(this.useCaseName_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(140, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(547, 662);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.useCaseSummary);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 56);
            this.panel2.TabIndex = 1;
            // 
            // useCaseSummary
            // 
            this.useCaseSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useCaseSummary.Location = new System.Drawing.Point(140, 0);
            this.useCaseSummary.Name = "useCaseSummary";
            this.useCaseSummary.Size = new System.Drawing.Size(401, 31);
            this.useCaseSummary.TabIndex = 1;
            this.useCaseSummary.TextChanged += new System.EventHandler(this.useCaseSummary_TextChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(140, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Summary:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 127);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel3.Size = new System.Drawing.Size(541, 74);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.actorsBox);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(140, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 54);
            this.panel5.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.DropDownWidth = 100;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(349, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(0, 38);
            this.comboBox1.TabIndex = 0;
            // 
            // actorsBox
            // 
            this.actorsBox.AutoSize = true;
            this.actorsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorsBox.Location = new System.Drawing.Point(0, 0);
            this.actorsBox.Margin = new System.Windows.Forms.Padding(0);
            this.actorsBox.MaximumSize = new System.Drawing.Size(349, 0);
            this.actorsBox.MinimumSize = new System.Drawing.Size(0, 52);
            this.actorsBox.Name = "actorsBox";
            this.actorsBox.Padding = new System.Windows.Forms.Padding(0, 0, 5, 7);
            this.actorsBox.Size = new System.Drawing.Size(349, 52);
            this.actorsBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(349, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "✚";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(140, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Actors:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.useCaseAssuming);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(541, 56);
            this.panel4.TabIndex = 3;
            // 
            // useCaseAssuming
            // 
            this.useCaseAssuming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useCaseAssuming.Location = new System.Drawing.Point(140, 0);
            this.useCaseAssuming.Name = "useCaseAssuming";
            this.useCaseAssuming.Size = new System.Drawing.Size(401, 31);
            this.useCaseAssuming.TabIndex = 1;
            this.useCaseAssuming.TextChanged += new System.EventHandler(this.useCaseAssuming_TextChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(140, 56);
            this.label4.TabIndex = 0;
            this.label4.Text = "Assuming:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.useCaseDescription);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 269);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel6.Size = new System.Drawing.Size(541, 156);
            this.panel6.TabIndex = 4;
            // 
            // useCaseDescription
            // 
            this.useCaseDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useCaseDescription.Location = new System.Drawing.Point(140, 0);
            this.useCaseDescription.Multiline = true;
            this.useCaseDescription.Name = "useCaseDescription";
            this.useCaseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.useCaseDescription.Size = new System.Drawing.Size(401, 136);
            this.useCaseDescription.TabIndex = 1;
            this.useCaseDescription.TextChanged += new System.EventHandler(this.useCaseDescription_TextChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(140, 136);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.useCaseExceptions);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 431);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel7.Size = new System.Drawing.Size(541, 156);
            this.panel7.TabIndex = 5;
            // 
            // useCaseExceptions
            // 
            this.useCaseExceptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useCaseExceptions.Location = new System.Drawing.Point(140, 0);
            this.useCaseExceptions.Multiline = true;
            this.useCaseExceptions.Name = "useCaseExceptions";
            this.useCaseExceptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.useCaseExceptions.Size = new System.Drawing.Size(401, 136);
            this.useCaseExceptions.TabIndex = 1;
            this.useCaseExceptions.TextChanged += new System.EventHandler(this.useCaseExceptions_TextChanged);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(140, 136);
            this.label6.TabIndex = 0;
            this.label6.Text = "Exceptions:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.useCaseResult);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 593);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(541, 56);
            this.panel8.TabIndex = 6;
            // 
            // useCaseResult
            // 
            this.useCaseResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useCaseResult.Location = new System.Drawing.Point(140, 0);
            this.useCaseResult.Name = "useCaseResult";
            this.useCaseResult.Size = new System.Drawing.Size(401, 31);
            this.useCaseResult.TabIndex = 1;
            this.useCaseResult.TextChanged += new System.EventHandler(this.useCaseResult_TextChanged);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(140, 56);
            this.label7.TabIndex = 0;
            this.label7.Text = "Result:";
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(587, 702);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PropertiesForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "PropertiesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox useCaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox useCaseSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox useCaseAssuming;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel actorsBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox useCaseDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox useCaseExceptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox useCaseResult;
        private System.Windows.Forms.Label label7;
    }
}