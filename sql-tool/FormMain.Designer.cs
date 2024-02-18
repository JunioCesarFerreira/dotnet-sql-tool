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
            Prompt_Output = new RichTextBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            Button_settings = new Button();
            Button_Open = new Button();
            ComboBoxDbs = new ComboBox();
            Button_History = new Button();
            Button_Help = new Button();
            Button_Close = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            Prompt_Input = new RichTextBox();
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
            tableLayoutPanel4.Controls.Add(Prompt_Output, 0, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 236);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(779, 182);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // Prompt_Output
            // 
            Prompt_Output.BackColor = Color.Black;
            Prompt_Output.BorderStyle = BorderStyle.None;
            Prompt_Output.Dock = DockStyle.Fill;
            Prompt_Output.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Prompt_Output.ForeColor = Color.FromArgb(255, 255, 128);
            Prompt_Output.Location = new Point(3, 22);
            Prompt_Output.Name = "Prompt_Output";
            Prompt_Output.Size = new Size(773, 157);
            Prompt_Output.TabIndex = 2;
            Prompt_Output.Text = "";
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
            tableLayoutPanel2.Controls.Add(Button_settings, 0, 0);
            tableLayoutPanel2.Controls.Add(Button_Open, 1, 0);
            tableLayoutPanel2.Controls.Add(ComboBoxDbs, 0, 0);
            tableLayoutPanel2.Controls.Add(Button_History, 6, 0);
            tableLayoutPanel2.Controls.Add(Button_Help, 5, 0);
            tableLayoutPanel2.Controls.Add(Button_Close, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(779, 39);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Button_settings
            // 
            Button_settings.Anchor = AnchorStyles.None;
            Button_settings.FlatStyle = FlatStyle.Flat;
            Button_settings.ForeColor = Color.White;
            Button_settings.Location = new Point(253, 7);
            Button_settings.Name = "Button_settings";
            Button_settings.Size = new Size(24, 25);
            Button_settings.TabIndex = 10;
            Button_settings.Text = "⚙️";
            Button_settings.UseVisualStyleBackColor = true;
            // 
            // Button_Open
            // 
            Button_Open.Anchor = AnchorStyles.None;
            Button_Open.FlatStyle = FlatStyle.Flat;
            Button_Open.ForeColor = Color.White;
            Button_Open.Location = new Point(283, 7);
            Button_Open.Name = "Button_Open";
            Button_Open.Size = new Size(75, 25);
            Button_Open.TabIndex = 5;
            Button_Open.Text = "Abrir";
            Button_Open.UseVisualStyleBackColor = true;
            // 
            // ComboBoxDbs
            // 
            ComboBoxDbs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxDbs.FormattingEnabled = true;
            ComboBoxDbs.Location = new Point(3, 8);
            ComboBoxDbs.Name = "ComboBoxDbs";
            ComboBoxDbs.Size = new Size(244, 23);
            ComboBoxDbs.TabIndex = 0;
            // 
            // Button_History
            // 
            Button_History.Anchor = AnchorStyles.None;
            Button_History.FlatStyle = FlatStyle.Flat;
            Button_History.ForeColor = Color.White;
            Button_History.Location = new Point(701, 7);
            Button_History.Name = "Button_History";
            Button_History.Size = new Size(75, 25);
            Button_History.TabIndex = 7;
            Button_History.Text = "Histórico";
            Button_History.UseVisualStyleBackColor = true;
            // 
            // Button_Help
            // 
            Button_Help.Anchor = AnchorStyles.None;
            Button_Help.FlatStyle = FlatStyle.Flat;
            Button_Help.ForeColor = Color.White;
            Button_Help.Location = new Point(620, 7);
            Button_Help.Name = "Button_Help";
            Button_Help.Size = new Size(75, 25);
            Button_Help.TabIndex = 1;
            Button_Help.Text = "Ajuda";
            Button_Help.UseVisualStyleBackColor = true;
            Button_Help.Click += Button_Help_Click;
            // 
            // Button_Close
            // 
            Button_Close.Anchor = AnchorStyles.None;
            Button_Close.FlatStyle = FlatStyle.Flat;
            Button_Close.ForeColor = Color.White;
            Button_Close.Location = new Point(364, 7);
            Button_Close.Name = "Button_Close";
            Button_Close.Size = new Size(75, 25);
            Button_Close.TabIndex = 6;
            Button_Close.Text = "Fechar";
            Button_Close.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(Prompt_Input, 0, 1);
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
            // Prompt_Input
            // 
            Prompt_Input.BackColor = Color.Black;
            Prompt_Input.BorderStyle = BorderStyle.None;
            Prompt_Input.Dock = DockStyle.Fill;
            Prompt_Input.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Prompt_Input.ForeColor = Color.FromArgb(255, 255, 128);
            Prompt_Input.Location = new Point(3, 22);
            Prompt_Input.Name = "Prompt_Input";
            Prompt_Input.Size = new Size(773, 157);
            Prompt_Input.TabIndex = 1;
            Prompt_Input.Text = "";
            Prompt_Input.KeyDown += prompt_sql_KeyDown;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(785, 421);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(630, 300);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ComboBox ComboBoxDbs;
        private Button Button_Help;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private RichTextBox Prompt_Output;
        private RichTextBox Prompt_Input;
        private Button Button_Close;
        private Button Button_Open;
        private Button Button_History;
        private Button Button_settings;
    }
}
