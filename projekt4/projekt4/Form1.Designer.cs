namespace projekt4
{
    partial class ToDoApp
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
            panelMenu = new Panel();
            CmdClick = new Button();
            CmdClick4 = new Button();
            CmdClick3 = new Button();
            CmdClick2 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            CmdClick6 = new Button();
            CmdClick7 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SlateBlue;
            panelMenu.Controls.Add(CmdClick);
            panelMenu.Controls.Add(CmdClick4);
            panelMenu.Controls.Add(CmdClick3);
            panelMenu.Controls.Add(CmdClick2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(273, 1102);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // CmdClick
            // 
            CmdClick.BackColor = SystemColors.Control;
            CmdClick.FlatStyle = FlatStyle.Flat;
            CmdClick.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CmdClick.ForeColor = Color.Black;
            CmdClick.Location = new Point(14, 355);
            CmdClick.Name = "CmdClick";
            CmdClick.Size = new Size(222, 116);
            CmdClick.TabIndex = 5;
            CmdClick.Text = "Hinzufügen";
            CmdClick.UseVisualStyleBackColor = false;
            CmdClick.Click += CmdClick_Click;
            // 
            // CmdClick4
            // 
            CmdClick4.BackColor = SystemColors.Control;
            CmdClick4.FlatStyle = FlatStyle.Flat;
            CmdClick4.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CmdClick4.ForeColor = Color.Black;
            CmdClick4.Location = new Point(14, 768);
            CmdClick4.Margin = new Padding(3, 4, 3, 4);
            CmdClick4.Name = "CmdClick4";
            CmdClick4.Size = new Size(222, 111);
            CmdClick4.TabIndex = 4;
            CmdClick4.Text = "Liste";
            CmdClick4.UseVisualStyleBackColor = false;
            CmdClick4.Click += button4_Click;
            // 
            // CmdClick3
            // 
            CmdClick3.BackColor = SystemColors.Control;
            CmdClick3.FlatStyle = FlatStyle.Flat;
            CmdClick3.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CmdClick3.ForeColor = Color.Black;
            CmdClick3.Location = new Point(14, 632);
            CmdClick3.Margin = new Padding(3, 4, 3, 4);
            CmdClick3.Name = "CmdClick3";
            CmdClick3.Size = new Size(222, 111);
            CmdClick3.TabIndex = 3;
            CmdClick3.Text = "Infos";
            CmdClick3.UseVisualStyleBackColor = false;
            CmdClick3.Click += button3_Click;
            // 
            // CmdClick2
            // 
            CmdClick2.BackColor = SystemColors.ButtonHighlight;
            CmdClick2.FlatStyle = FlatStyle.Flat;
            CmdClick2.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CmdClick2.ForeColor = Color.Black;
            CmdClick2.Location = new Point(14, 501);
            CmdClick2.Margin = new Padding(3, 4, 3, 4);
            CmdClick2.Name = "CmdClick2";
            CmdClick2.Size = new Size(222, 111);
            CmdClick2.TabIndex = 2;
            CmdClick2.Text = "Datum";
            CmdClick2.UseVisualStyleBackColor = false;
            CmdClick2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(265, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 1327);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(checkedListBox2);
            panel3.Controls.Add(checkedListBox1);
            panel3.Controls.Add(CmdClick6);
            panel3.Controls.Add(CmdClick7);
            panel3.Controls.Add(listBox1);
            panel3.Location = new Point(47, 36);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1299, 1255);
            panel3.TabIndex = 1;
            // 
            // CmdClick6
            // 
            CmdClick6.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CmdClick6.Location = new Point(783, 19);
            CmdClick6.Name = "CmdClick6";
            CmdClick6.Size = new Size(363, 43);
            CmdClick6.TabIndex = 2;
            CmdClick6.Text = "Datum";
            CmdClick6.UseVisualStyleBackColor = true;
            CmdClick6.Click += CmdClick6_Click;
            // 
            // CmdClick7
            // 
            CmdClick7.BackColor = SystemColors.Control;
            CmdClick7.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CmdClick7.ForeColor = Color.Black;
            CmdClick7.Location = new Point(78, 19);
            CmdClick7.Name = "CmdClick7";
            CmdClick7.Size = new Size(465, 43);
            CmdClick7.TabIndex = 1;
            CmdClick7.Text = "Aktivitäten";
            CmdClick7.UseVisualStyleBackColor = false;
            CmdClick7.Click += CmdClick7_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(659, 4);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(636, 1204);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 135);
            label1.MaximumSize = new Size(2286, 266667);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Location = new Point(1658, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 1327);
            panel2.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(78, 146);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(468, 576);
            checkedListBox1.TabIndex = 3;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(741, 146);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(468, 576);
            checkedListBox2.TabIndex = 4;
            // 
            // ToDoApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1936, 1102);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ToDoApp";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button CmdClick4;
        private Button CmdClick3;
        private Button CmdClick2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private ListBox listBox1;
        private Button CmdClick;
        private Button CmdClick6;
        private Button CmdClick7;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
    }
}