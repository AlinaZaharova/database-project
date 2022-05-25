using LibraryApp.Forms;
using LibraryApp.Helpers;
using LibraryApp.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddEditBook : BaseForm
    {
        private Book _book;

        public AddEditBook(User user, Book book = null) : base(user)
        {
            InitializeComponent();

            _book = book;

            if (_book == null)
            {
                lbl_Title.Text = "Добавить книгу";
            }
            else
            {
                lbl_Title.Text = "Редактировать книгу";
                txt_Title.Text = book.Title;
                cb_owned.Visible = book.OwnerUser == 0 ? false : true;
                cb_owned.CheckState = book.OwnerUser == 0 ? CheckState.Unchecked : CheckState.Checked;
            }
        }

        private void btn_saveBook_Click(object sender, EventArgs e)
        {
            Author author = (Author)cb_Author.SelectedItem;
            Genre genre = (Genre)cb_Genre.SelectedItem;

            if (string.IsNullOrEmpty(txt_Title.Text) || author == null || genre == null)
            {
                MessageBox.Show(this, "Заполните все необходимые поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (_book == null)
                {
                    DBContext.AddBook(new Book
                    {
                        Title = txt_Title.Text,
                        Author = author,
                        Genre = genre
                    });
                    Logger.CreateRecord($"Добавлена книга {_book.Title}");
                }

                else
                {
                    if (!cb_owned.Checked)
                    {
                        var newBook = new Book
                        {
                            Id = _book.Id,
                            Title = txt_Title.Text,
                            Author = author,
                            Genre = genre,
                            OwnerUser = 0,
                            BookedUser = 0
                        };
                        DBContext.EditBook(newBook);
                        CreateLogsRecord(_book, newBook);
                        Close();
                        return;
                    }
                    else
                    {
                        var newBook = new Book
                        {
                            Id = _book.Id,
                            Title = txt_Title.Text,
                            Author = author,
                            Genre = genre,
                            OwnerUser = _book.OwnerUser,
                            BookedUser = _book.BookedUser
                        };

                        DBContext.EditBook(newBook);
                        CreateLogsRecord(_book, newBook);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }

        private void AddEditBook_Load(object sender, EventArgs e)
        {
            var genres = DBContext.GetAllGenres();
            var authors = DBContext.GetAllAuthors();

            cb_Author.DataSource = authors;
            cb_Author.DisplayMember = "Name";

            cb_Genre.DataSource = genres;
            cb_Genre.DisplayMember = "Name";

            if (_book != null)
            {
                cb_Author.SelectedItem = authors.FirstOrDefault(x => x.Id == _book.Author.Id);
                cb_Genre.SelectedItem = genres.FirstOrDefault(x => x.Id == _book.Genre.Id);

            }

        }

        private void CreateLogsRecord(Book oldBook, Book newBook) 
        {
            if(!cb_owned.Checked && oldBook.OwnerUser != 0 && newBook.OwnerUser == 0)
                 Logger.CreateRecord($"Возвращена книга {_book.Title} от userId: {_book.OwnerUser}");
            if(oldBook.Title != newBook.Title)
                 Logger.CreateRecord($"Изменено название у книги {oldBook.Title} -> {newBook.Title}");
             if(oldBook.Author.Name != newBook.Author.Name)
                 Logger.CreateRecord($"Изменен автор у книги {oldBook.Id} {oldBook.Author.Name} -> {newBook.Author.Name}");
              if(oldBook.Genre.Name != newBook.Genre.Name)
                 Logger.CreateRecord($"Изменен жанр у книги {oldBook.Id} {oldBook.Genre.Name} -> {newBook.Genre.Name}");
        }
    }
}
