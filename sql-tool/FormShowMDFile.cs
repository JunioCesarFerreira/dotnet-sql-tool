namespace sql_tool
{
    public partial class FormShowMDFile : Form
    {
        private readonly string _pathFile;

        private SQLHighlighterRules sqlHighlighterRules;

        public FormShowMDFile(string pathFile)
        {
            InitializeComponent();
            _pathFile = pathFile;

            sqlHighlighterRules = new SQLHighlighterRules(RichTextBox_MDFile);
            RichTextBox_MDFile.TextChanged += (sender, e) => sqlHighlighterRules.HighlightSyntax();
        }

        private void FormShowMDFile_Load(object sender, EventArgs e)
        {
            RichTextBox_MDFile.Text = File.ReadAllText(_pathFile);

        }
    }
}
