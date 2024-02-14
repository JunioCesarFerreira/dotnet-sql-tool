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
            RichTextBox_Markdown_View = new RichTextBox();
            SuspendLayout();
            // 
            // RichTextBox_Markdown_View
            // 
            RichTextBox_Markdown_View.BackColor = Color.Black;
            RichTextBox_Markdown_View.BorderStyle = BorderStyle.None;
            RichTextBox_Markdown_View.Dock = DockStyle.Fill;
            RichTextBox_Markdown_View.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTextBox_Markdown_View.ForeColor = Color.FromArgb(255, 255, 128);
            RichTextBox_Markdown_View.Location = new Point(0, 0);
            RichTextBox_Markdown_View.Name = "RichTextBox_Markdown_View";
            RichTextBox_Markdown_View.Size = new Size(800, 450);
            RichTextBox_Markdown_View.TabIndex = 2;
            RichTextBox_Markdown_View.Text = "";
            // 
            // FormShowMDFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RichTextBox_Markdown_View);
            Name = "FormShowMDFile";
            Text = "FormShowMDFile";
            Load += FormShowMDFile_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RichTextBox_Markdown_View;
    }
}