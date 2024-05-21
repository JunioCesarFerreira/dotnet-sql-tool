using System.Text.RegularExpressions;

namespace sql_tool
{
    internal class SQLHighlighterRules : HighlighterBase
    {
        public SQLHighlighterRules(RichTextBox richTextBox) : base(richTextBox, Color.White) { }


        protected override void Highlight()
        {
            HighlightPattern(@"\b(SELECT|UPDATE|DELETE|INSERT|FROM|WHERE|AND|OR|NOT|IN|AS|LIKE|INTO|CREATE|DROP|ALTER|ORDER|SET)\b",
                Color.DeepSkyBlue, RegexOptions.IgnoreCase, FontStyle.Bold);

            HighlightPattern(@"'[^']*'", Color.OrangeRed);

            HighlightPattern(@"--.*$", Color.Green, RegexOptions.Multiline, FontStyle.Italic);

        }
    }
}