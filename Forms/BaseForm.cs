using LibraryApp.Helpers;
using LibraryApp.Models;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public class BaseForm : Form
    {
        protected DatabaseWorker DBContext = new DatabaseWorker();
        protected JournalWorker Logger;

        public BaseForm()
        {

        }

        public BaseForm(User user)
        {
            Logger = new JournalWorker(user);
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
