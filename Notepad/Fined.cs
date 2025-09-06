namespace Notepad
{
    public partial class Fined : Form
    {

        Form1 _form;
        public Fined(Form1 form)
        {
            _form = form;
            InitializeComponent();
        }

        private void btnFined_Click(object sender, EventArgs e)
        {
            _form.Fined(txtFined.Text);
        }
    }
}
