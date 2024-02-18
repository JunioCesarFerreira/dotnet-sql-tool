using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

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
            RichTextBox_MDFile.Text = File.ReadAllText(_pathFile);
            ColoringText();
        }

        public void ColoringText()
        {
            string[] wordsToColorize = { "SELECT", "FROM", "WHERE", "INSERT", "INTO", "UPDATE", "DELETE", "CREATE", "ALTER", "DROP", "TABLE", "INDEX", "JOIN", "INNER", "OUTER", "LEFT", "RIGHT", "GROUP", "BY", "ORDER", "HAVING", "AND", "OR", "NOT", "IN", "BETWEEN", "LIKE", "AS", "DISTINCT", "COUNT", "SUM", "AVG", "MAX", "MIN", "ALL", "ANY", "EXISTS", "UNION", "INTERSECT", "EXCEPT", "CASE", "WHEN", "THEN", "ELSE", "END", "BEGIN", "COMMIT", "ROLLBACK", "TRANSACTION", "GRANT", "REVOKE", "USER", "DATABASE", "VIEW", "PROCEDURE", "TRIGGER", "CASCADE", "PRIMARY", "KEY", "FOREIGN", "CONSTRAINT", "SET", "VALUES"};

            foreach (string  word in wordsToColorize)
            {
                int startIndex = 0;
                while(startIndex < RichTextBox_MDFile.TextLength)
                {
                    int wordStartIndex = RichTextBox_MDFile.Find(word, startIndex, RichTextBoxFinds.WholeWord | RichTextBoxFinds.MatchCase);
                    if (wordStartIndex != -1)
                    {
                        RichTextBox_MDFile.Select(wordStartIndex, word.Length);
                        RichTextBox_MDFile.SelectionColor = Color.Red;
                        RichTextBox_MDFile.SelectionFont = new Font(RichTextBox_MDFile.Font, FontStyle.Bold);
                        startIndex = wordStartIndex + word.Length;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
