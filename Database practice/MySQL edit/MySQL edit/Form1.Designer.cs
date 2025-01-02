namespace MySQL_edit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 150);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(43, 59);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 0;
            label1.Text = "roome info";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(46, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 660);
            panel2.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.BackgroundColor = SystemColors.Window;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView.GridColor = SystemColors.ButtonHighlight;
            dataGridView.Location = new Point(34, 94);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(655, 501);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(446, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(47, 38);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "room";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "chore";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.FlatStyle = FlatStyle.Flat;
            Column5.HeaderText = "";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Text = "Edit";
            Column5.UseColumnTextForButtonValue = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.FlatStyle = FlatStyle.Flat;
            Column6.HeaderText = "";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "Delet";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 858);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "EditDB";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column6;
    }
}