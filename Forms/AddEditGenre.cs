using LibraryApp.Helpers;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class AddEditGenre : BaseForm
    {
        private BindingSource _bs = new BindingSource();
        private DataSet _ds = new DataSet();
        public AddEditGenre(User user) : base(user)
        {
            InitializeComponent();
        }

        private void AddEditGenre_Load(object sender, EventArgs e)
        {
            RefreshState();
        }

        private void RefreshState()
        {
            _bs.DataSource = DBContext.GetAllGenres();
            dgv.DataSource = _bs;
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    if (row.DataBoundItem is Genre genre)
                        DeleteItem(genre);
                }
                RefreshState();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_genre.Text))
                DBContext.AddGenre(txt_genre.Text);
            RefreshState();
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Genre genre = (Genre)dgv.Rows[e.RowIndex].DataBoundItem;

            if (string.IsNullOrEmpty(genre.Name))
            {
                DeleteItem(genre);
                Logger.CreateRecord($"Удален жанр {genre.Name}");
            }
            else
            {
                Genre oldGenre = DBContext.GetAllGenres().FirstOrDefault(x => x.Id == genre.Id);
                DBContext.EditGenre(genre);
                Logger.CreateRecord($"Изменен жанр {oldGenre.Name} -> {genre.Name}");
            }
            RefreshState();
        }

        private void DeleteItem(Genre genre)
        {
            try
            {
                DBContext.DeleteGenre(genre.Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Поле используется", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
              dgv.BeginEdit(false);
        }
    }
}
