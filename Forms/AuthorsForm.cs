using LibraryApp.Extensions;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class AuthorsForm : BaseForm
    {
        private BindingSource _bs = new BindingSource();
        private IEnumerable<Country> _countires;
        private User _user;
        public AuthorsForm(User user) : base(user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void RefreshState()
        {
            _countires = DBContext.GetAllCountries();

            if (dataset.Tables.Count > 0) 
            {
                dataset.Tables.Clear();
            }

            dataset.Tables.Add(DBContext.GetAllAuthors().ToDataTable());
            dataset.Tables.Add(_countires.ToDataTable());

            dgv.Columns["Id"].Visible = false;
            dgv.Columns["AuthorName"].DataPropertyName = "Name";
            dgv.DataSource = dataset.Tables[0];

            if (dgv.Columns["Country"] is DataGridViewComboBoxColumn column)
            {
                column.DataSource = dataset.Tables[1];
                column.DisplayMember = "Name";
            }


            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Country"] is DataGridViewComboBoxCell cell)
                {
                    DataRow dsRow = dataset.Tables[0].Rows[row.Index];
                    Country country = (Country)dsRow[3];
                    cell.Value = country.Name;
                }
            }
        }


        private void AddEditAuthor_Load(object sender, EventArgs e)
        {
            RefreshState();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddAuthorForm form = new AddAuthorForm(_user);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            RefreshState();
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DBContext.DeleteAuthor((int)dataset.Tables[0].Rows[dgv.SelectedCells[0].RowIndex].ItemArray[0]);
                Logger.CreateRecord($"Удален автор: {(string)dataset.Tables[0].Rows[dgv.SelectedCells[0].RowIndex].ItemArray[1]}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Поле используется", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefreshState();
        }

        private void Save() 
        {
          List<Author> list = new List<Author>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRowView author = (DataRowView)row.DataBoundItem;
                string countryName = (string)row.Cells["Country"].Value;

                list.Add(new Author
                {
                    Id = Convert.ToInt32(author.Row.ItemArray[0]),
                    Name = (string)author.Row.ItemArray[1],
                    DateOfBirth = (DateTime)author.Row.ItemArray[2],
                    Country = _countires.FirstOrDefault(x => x.Name == countryName)
                });
            }
            var currentAuthors = DBContext.GetAllAuthors();
            CreateLogs(currentAuthors, list);
            DBContext.SaveAuthors(list);
            Close();
        }

        private void CreateLogs(IEnumerable<Author> oldList, List<Author> newlist)
        {
            var newAuthors = newlist.Select(x => x.Id).Except(oldList.Select(x => x.Id));
            var deletedAuthors = oldList.Select(x => x.Id).Except(newlist.Select(x => x.Id));
            var changedNames = newlist.Select(x => x.Name).Except(oldList.Select(x => x.Name));
            
            foreach (var s in newAuthors) 
            {
                Logger.CreateRecord($"Добавлены авторы: {s}");
            }

            foreach (var s in changedNames) 
            {
                Logger.CreateRecord($"Изменено имя автора: {s}");
            }
        }
    }
}
