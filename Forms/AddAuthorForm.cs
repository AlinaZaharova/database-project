using LibraryApp.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class AddAuthorForm : BaseForm
    {
        public AddAuthorForm(User user) : base(user)
        {
            InitializeComponent();

            var countries = DBContext.GetAllCountries();

            cb_Counties.DataSource = countries;
            cb_Counties.DisplayMember = "Name";
            cb_Counties.SelectedItem = countries.FirstOrDefault();
        }

        private void btn_saveBook_Click(object sender, EventArgs e)
        {
            try
            {
                var author = new Author
                {
                    Name = txt_Name.Text,
                    DateOfBirth = Convert.ToDateTime(txt_date.Text),
                    Country = (Country)cb_Counties.SelectedItem
                };

                DBContext.AddAuthor(author);
                Logger.CreateRecord($"Добавлен автор:{author.Name}");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
