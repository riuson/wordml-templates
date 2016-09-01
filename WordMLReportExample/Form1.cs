using System;
using System.Linq;
using System.Windows.Forms;

namespace WordMLReportExample
{
    public partial class Form1 : Form
    {
        private string mTemplateFileName;
        private string mSelectedBookmark;
        private string mValue;

        public Form1()
        {
            InitializeComponent();
            this.mTemplateFileName = this.mSelectedBookmark = this.mValue = String.Empty;
        }

        private void buttonSelectTemplateFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.Filter = "MS Word OpenXML (*.docx)|*.docx";
                dialog.FilterIndex = 1;
                dialog.Multiselect = false;
                dialog.ShowReadOnly = true;
                dialog.Title = "Select file for template";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.mTemplateFileName = dialog.FileName;
                    this.textBoxTemplateFileName.Text = this.mTemplateFileName;
                }
            }
        }

        private void buttonShowBookmarks_Click(object sender, EventArgs e)
        {
            var bookmarks = Replacer.GetBookmarks(this.mTemplateFileName);
            this.listBoxBookmarks.Items.Clear();
            this.listBoxBookmarks.Items.AddRange(bookmarks.Select(x => x.Start.Name).ToArray());
        }

        private void buttonReplaceAndSave_Click(object sender, EventArgs e)
        {
            this.mSelectedBookmark = Convert.ToString(this.listBoxBookmarks.SelectedItem);
            this.mValue = this.textBoxTextValue.Text;

            using (var dialog = new SaveFileDialog())
            {
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;
                dialog.Filter = "MS Word OpenXML (*.docx)|*.docx";
                dialog.FilterIndex = 1;
                dialog.Title = "Select file for result";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Replacer.ReplaceAndSave(this.mTemplateFileName, dialog.FileName, this.mSelectedBookmark, this.mValue);
                }
            }
        }
    }
}
