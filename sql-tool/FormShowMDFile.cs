using System;
using System.Drawing;
using System.IO;
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
            Colorizer.ColoringText(RichTextBox_MDFile);
        }
    }

    public static class Colorizer
    {
        public static void ColoringText(RichTextBox richTextBox)
        {
            string[] wordsToColorize = { "SELECT", "FROM", "WHERE", "INSERT", "INTO", "UPDATE", "DELETE", "CREATE", "ALTER", "DROP", "TABLE", "INDEX", "JOIN", "INNER", "OUTER", "LEFT", "RIGHT", "GROUP", "BY", "ORDER", "HAVING", "AND", "OR", "NOT", "IN", "BETWEEN", "LIKE", "AS", "DISTINCT", "COUNT", "SUM", "AVG", "MAX", "MIN", "ALL", "ANY", "EXISTS", "UNION", "INTERSECT", "EXCEPT", "CASE", "WHEN", "THEN", "ELSE", "END", "BEGIN", "COMMIT", "ROLLBACK", "TRANSACTION", "GRANT", "REVOKE", "USER", "DATABASE", "VIEW", "PROCEDURE", "TRIGGER", "CASCADE", "PRIMARY", "KEY", "FOREIGN", "CONSTRAINT", "SET", "VALUES", "*" };

            foreach (string word in wordsToColorize)
            {
                int startIndex = 0;
                while (startIndex < richTextBox.TextLength)
                {
                    int wordStartIndex = richTextBox.Find(word, startIndex, RichTextBoxFinds.WholeWord | RichTextBoxFinds.MatchCase);
                    if (wordStartIndex != -1)
                    {
                        richTextBox.Select(wordStartIndex, word.Length);
                        richTextBox.SelectionColor = Color.Red;
                        richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
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
