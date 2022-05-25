using LibraryApp.Forms;
using LibraryApp.Helpers;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp.UserControls
{
    public partial class BooksUC : UserControl
    {
        private User _user;
        private List<Book> _books;
        private DatabaseWorker _db = new DatabaseWorker();
        private BindingSource _bindingSource = new BindingSource();

        public BooksUC(User user)
        {
            InitializeComponent();
            _user = user;

            if (_user.IsAdmin)
            {
                InitializeAdminView();
            }
            else
            {
                InitializeUserView();
            }

            RefreshData();
        }

        private void InitializeAdminView()
        {
            panel_admin.Visible = true;
            panel_user.Visible = false;
            panel_admin.Location = new System.Drawing.Point(347, 281);
            gb_dgv.Text = "Книги";
        }

        private void InitializeUserView()
        {
            panel_admin.Visible = false;
            panel_user.Visible = true;
            panel_admin.Location = new System.Drawing.Point(347, 281);
            gb_dgv.Text = "Мои книги";
        }

        #region Buttons 
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddEditBook addEditForm = new AddEditBook(_user);
            addEditForm.StartPosition = FormStartPosition.CenterScreen;
            addEditForm.ShowDialog();
            RefreshData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                Book selectedBook = dgv.SelectedRows[0].DataBoundItem as Book;
                AddEditBook addEditForm = new AddEditBook(_user, selectedBook);
                addEditForm.StartPosition = FormStartPosition.CenterScreen;
                addEditForm.ShowDialog();
                RefreshData();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1 && _user.IsAdmin)
            {
                Book selectedBook = dgv.SelectedRows[0].DataBoundItem as Book;
                _db.DeleteBook(selectedBook.Id);
            }
            RefreshData();
        }

        private void btn_authors_Click(object sender, EventArgs e)
        {
            AuthorsForm form = new AuthorsForm(_user);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            RefreshData();
        }

        private void btn_genres_Click(object sender, EventArgs e)
        {
            AddEditGenre form = new AddEditGenre(_user);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            RefreshData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = ParentForm;
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            Dispose();
        }
        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderBook orderBook = new OrderBook(_user);
            orderBook.StartPosition = FormStartPosition.CenterScreen;
            orderBook.ShowDialog();
            RefreshData();
        }

        private void btn_handBook_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                Book selectedBook = dgv.SelectedRows[0].DataBoundItem as Book;
                HandOverBook handForm = new HandOverBook(_user, selectedBook);
                handForm.StartPosition = FormStartPosition.CenterScreen;
                handForm.ShowDialog();
                RefreshData();
            }
            RefreshData();
        }
        #endregion

        private void BooksUC_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            if (_user.IsAdmin)
            {
                _books = _db.GetAllBooks().ToList();
            }
            else
            {
                _books = _db.GetBooksByUser(_user).ToList();
            }

            _bindingSource.DataSource = _books;
            dgv.DataSource = _bindingSource;

            FormatCells();

        }

        private void FormatCells()
        {
            if (!_user.IsAdmin)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.DataBoundItem is Book book)
                    {
                        row.Cells["Genre"].Value = book.Genre.Name;
                        row.Cells["Author"].Value = book.Author.Name;
                        row.Cells["BookedUser"].Value = book.BookedUser != 0 ? "да" : string.Empty;
                        row.Cells["OwnerUser"].Value = book.OwnerUser != 0 ? "да" : string.Empty;
                    }
                }
            }

            else
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.DataBoundItem is Book book)
                    {
                        row.Cells["Genre"].Value = book.Genre.Name;
                        row.Cells["Author"].Value = book.Author.Name;
                        row.Cells["BookedUser"].Value = book.BookedUser != 0 ? $"ID: {book.BookedUser}" : string.Empty;
                        row.Cells["OwnerUser"].Value = book.OwnerUser != 0 ? $"ID: {book.OwnerUser}" : string.Empty;
                    }
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                try
                {
                    _bindingSource.DataSource = _books.Where(x => x.Author.Name.Contains(textbox.Text) || x.Title.Contains(textbox.Text));
                    dgv.DataSource = _bindingSource;
                    FormatCells();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count == 1 && _user.IsAdmin)
            {
                Book selectedBook = dgv.SelectedRows[0].DataBoundItem as Book;
                AddEditBook addEditForm = new AddEditBook(_user, selectedBook);
                addEditForm.StartPosition = FormStartPosition.CenterScreen;
                addEditForm.ShowDialog();
                RefreshData();
            }
        }

        private void btn_Journal_Click(object sender, EventArgs e)
        {
            JournalForm form = new JournalForm();
            form.ShowDialog();
        }
    }
}

