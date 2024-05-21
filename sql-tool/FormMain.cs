using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace sql_tool
{
    public partial class FormMain : Form
    {
        private SQLHighlighterRules sqlHighlighterRules;
        public FormMain()
        {
            InitializeComponent();

            sqlHighlighterRules = new SQLHighlighterRules(Prompt_Input);
            Prompt_Input.TextChanged += (sender, e) => sqlHighlighterRules.HighlightSyntax();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void Button_Help_Click(object sender, EventArgs e)
        {
            string helpFile = AppDomain.CurrentDomain.BaseDirectory + "\\ComandosBasicosSQL.md";
            FormShowMDFile formShowMDFile = new(helpFile);
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
