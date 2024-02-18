namespace sql_tool
{
    partial class FormShowMDFile
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
            RichTextBox_MDFile = new RichTextBox();
            SuspendLayout();
            // 
            // RichTextBox_MDFile
            // 
            RichTextBox_MDFile.BackColor = Color.Black;
            RichTextBox_MDFile.BorderStyle = BorderStyle.None;
            RichTextBox_MDFile.Dock = DockStyle.Fill;
            RichTextBox_MDFile.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTextBox_MDFile.ForeColor = Color.FromArgb(255, 255, 128);
            RichTextBox_MDFile.Location = new Point(5, 5);
            RichTextBox_MDFile.Margin = new Padding(5);
            RichTextBox_MDFile.Name = "RichTextBox_MDFile";
            RichTextBox_MDFile.ReadOnly = true;
            RichTextBox_MDFile.Size = new Size(790, 440);
            RichTextBox_MDFile.TabIndex = 2;
            RichTextBox_MDFile.Text = "";
            // 
            // FormShowMDFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(RichTextBox_MDFile);
            Name = "FormShowMDFile";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormShowMDFile";
            Load += FormShowMDFile_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RichTextBox_MDFile;
    }
}