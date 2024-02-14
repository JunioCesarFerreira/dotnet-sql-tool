using System;
using System.IO;

namespace sql_tool
{
    public partial class FormShowMDFile : Form
    {
        private readonly string _pathFile;

        public FormShowMDFile(string pathFile)
        {
            InitializeComponent();
            _pathFile = pathFile;
        }

        private void FormShowMDFile_Load(object sender, EventArgs e)
        {
            RichTextBox_Markdown_View.Text = File.ReadAllText(_pathFile);
        }
    }
}
