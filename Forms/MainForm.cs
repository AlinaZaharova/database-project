using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class MainForm : Form
    {
        private LoginForm _loginForm = new LoginForm();

        public MainForm()
        {
            InitializeComponent();
            ShowLoginForm();
        }

        public void ShowLoginForm()
        {
            _loginForm.MdiParent = this;
            _loginForm.StartPosition = FormStartPosition.CenterScreen;
            _loginForm.Show();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
