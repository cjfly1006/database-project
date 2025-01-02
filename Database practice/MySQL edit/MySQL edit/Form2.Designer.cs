namespace MySQL_edit
{
    partial class Form2
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnAdd = new Button();
            txtchore = new Label();
            textBox3 = new TextBox();
            txtreg = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            txtname = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 150);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 150);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(43, 59);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Roome";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtchore);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(txtreg);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtname);
            panel3.Location = new Point(24, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(721, 518);
            panel3.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(150, 334);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtchore
            // 
            txtchore.AutoSize = true;
            txtchore.Location = new Point(150, 202);
            txtchore.Name = "txtchore";
            txtchore.Size = new Size(56, 25);
            txtchore.TabIndex = 6;
            txtchore.Text = "chore";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(444, 31);
            textBox3.TabIndex = 5;
            // 
            // txtreg
            // 
            txtreg.AutoSize = true;
            txtreg.Location = new Point(150, 119);
            txtreg.Name = "txtreg";
            txtreg.Size = new Size(56, 25);
            txtreg.TabIndex = 4;
            txtreg.Text = "room";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(444, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 40);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 2;
            label2.Text = "name";
            // 
            // txtname
            // 
            txtname.Location = new Point(150, 68);
            txtname.Name = "txtname";
            txtname.Size = new Size(444, 31);
            txtname.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 751);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox txtname;
        private Label txtchore;
        private TextBox textBox3;
        private Label txtreg;
        private TextBox textBox2;
        private Label label2;
        private Button btnAdd;
    }
}