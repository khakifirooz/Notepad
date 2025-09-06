namespace Notepad
{
    public partial class Form1 : Form
    {
        string fileName;
        bool saveFile;
        ITools tools = new Tools();
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                saveFileDialog1.Filter = "Text Files (*.txt)|*.tet";
                DialogResult resault = saveFileDialog1.ShowDialog(this);
                if (resault == DialogResult.Cancel)
                    return;
                fileName = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fileName, Body.Text);
            this.Text = fileName;
            saveFile = true;
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            fileName = null;
            save_Click(null, null);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile == false)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save this file?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save_Click(null, null);
                }
                Body.Text = "";
                this.Text = "Notepad";
                saveFile = true;
                fileName = null;
            }
        }

        private void Body_TextChanged(object sender, EventArgs e)
        {
            saveFile = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile == false)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save this file?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save_Click(null, null);
                }
            }
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt;*.docx";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;

            fileName = openFileDialog1.FileName;
            Body.Text = System.IO.File.ReadAllText(fileName);
            this.Text = fileName;
            saveFile = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile == false)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save this file?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save_Click(null, null);
                }
            }
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Body.SelectedText);

        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body.SelectedText = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Body.SelectedText);
            Body.SelectedText = "";
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Body.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body.Text = tools.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body.Text = tools.Redo();
        }

        private void Body_KeyUp(object sender, KeyEventArgs e)
        {
            tools.Insert(Body.Text);
        }

        private void finedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fined form = new Fined(this);
            form.Show();
        }

        public void Fined(string str)
        {
           int index = Body.Text.IndexOf(str,0);
            if(index == -1)
            {
                MessageBox.Show("Not Found");
            }
            Body.SelectionStart = index;
            Body.SelectionLength = str.Length;
            Body.Focus();
        }
    }
}
