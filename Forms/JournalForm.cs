using System;

namespace LibraryApp.Forms
{
    public partial class JournalForm : BaseForm
    {
        public JournalForm() : base(null)
        {

            InitializeComponent();
        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
             dataGridView1.DataSource = DBContext.GetAllJournalRecords();
        }
    }
}
