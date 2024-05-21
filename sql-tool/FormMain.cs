using System;
using System.Diagnostics;

namespace sql_tool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void Button_Help_Click(object sender, EventArgs e)
        {
            string helpFile = AppDomain.CurrentDomain.BaseDirectory + "\\ComandosBasicosSQL.md";
            FormShowMDFile formShowMDFile = new FormShowMDFile(helpFile);
            formShowMDFile.Show();
        }

        private void Prompt_sql_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.Shift)
                {
                    MessageBox.Show("Apenas enter!");
                }
                else
                {
                    MessageBox.Show("Executa comando!");
                }
            }
        }
    }
}
