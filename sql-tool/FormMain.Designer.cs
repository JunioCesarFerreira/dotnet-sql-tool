namespace sql_tool
{
    partial class FormMain
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button5 = new Button();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            prompt_sql = new RichTextBox();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(785, 421);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(richTextBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 236);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(779, 182);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Black;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.ForeColor = Color.FromArgb(255, 255, 128);
            richTextBox2.Location = new Point(3, 22);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(773, 157);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(235, 19);
            label2.TabIndex = 1;
            label2.Text = "Prompt de mensagens do sistema";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(button4, 0, 0);
            tableLayoutPanel2.Controls.Add(button5, 1, 0);
            tableLayoutPanel2.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(button3, 6, 0);
            tableLayoutPanel2.Controls.Add(button1, 5, 0);
            tableLayoutPanel2.Controls.Add(button2, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(779, 39);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(283, 7);
            button5.Name = "button5";
            button5.Size = new Size(75, 25);
            button5.TabIndex = 5;
            button5.Text = "Abrir";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 23);
            comboBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(701, 7);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 7;
            button3.Text = "Histórico";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(620, 7);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 1;
            button1.Text = "Ajuda";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(364, 7);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 6;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(prompt_sql, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 48);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(779, 182);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 19);
            label1.TabIndex = 0;
            label1.Text = "Prompt comandos SQL";
            // 
            // prompt_sql
            // 
            prompt_sql.BackColor = Color.Black;
            prompt_sql.BorderStyle = BorderStyle.None;
            prompt_sql.Dock = DockStyle.Fill;
            prompt_sql.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prompt_sql.ForeColor = Color.FromArgb(255, 255, 128);
            prompt_sql.Location = new Point(3, 22);
            prompt_sql.Name = "prompt_sql";
            prompt_sql.Size = new Size(773, 157);
            prompt_sql.TabIndex = 1;
            prompt_sql.Text = "";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(253, 7);
            button4.Name = "button4";
            button4.Size = new Size(24, 25);
            button4.TabIndex = 10;
            button4.Text = "⚙️";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(785, 421);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(500, 300);
            Name = "FormMain";
            Text = "SQL Tool";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox2;
        private RichTextBox prompt_sql;
        private Button button2;
        private Button button5;
        private Button button3;
        private Button button4;
    }
}
