using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string Path { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
    public partial class MainForm : Form, IMainForm
    {
        
        public MainForm() 
        {
            InitializeComponent();
            ButOpenFile.Click += new EventHandler(ButOpenFile_Click);
            SaveBut.Click += SaveBut_Click;
            TextBoxContent.TextChanged += TextBoxContent_TextChanged;
            ButSelectFile.Click += butSelectFile_Click;
            numFont.ValueChanged += NumFont_ValueChanged;

        }


        #region Проброс событий
        private void TextBoxContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }

        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }
        #endregion
        #region ImainForm
        public string Path
        {
            get { return PathBox.Text; }
        }
        public string Content
        {
            get { return TextBoxContent.Text; }
            set { TextBoxContent.Text = value; }
        }
        public void SetSymbolCount(int count)
        {
            SymbolCountBox.Text = count.ToString();
        }
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;
        #endregion
        private void butSelectFile_Click(object sender , EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                PathBox.Text = dlg.FileName;
                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }
        }
        private void NumFont_ValueChanged(object sender, EventArgs e)
        {
            TextBoxContent.Font = new Font("Calibri", (float)numFont.Value);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
