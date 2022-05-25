using LibraryApp.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace LibraryApp.Helpers
{
    public class DatabaseWorker
    {
        private readonly string _connectionString = ConfigurationManager.AppSettings["DbConnection"];
        private TimeSpan _currentUtc = DateTime.Now - DateTime.UtcNow;

        public User GetUserByName(string name)
        {
            User user = new User();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = $@"SELECT * FROM USERS WHERE Name = @Name";
                command.Parameters.AddWithValue("Name", name);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Password = reader.GetString(2),
                            IsAdmin = reader.GetBoolean(3)
                        };
                    }
                }
                return user;
            }
        }

        public IEnumerable<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM COUNTRIES";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            countries.Add(new Country
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                            });
                        }
                    }
                }
                return countries;
            }
        }

         public IEnumerable<Journal> GetAllJournalRecords()
         {
            List<Journal> countries = new List<Journal>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM JOURNAL";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            countries.Add(new Journal
                            {
                                Id = reader.GetInt32(0),
                                DateOfOperation = reader.GetDateTime(1) + _currentUtc,
                                UserId = reader.GetInt32(2),
                                Operation = reader.GetString(3)
                            });
                        }
                    }
                }
                return countries;
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM USERS";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            users.Add(new User
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                IsAdmin = reader.GetBoolean(3),
                            });
                        }
                    }
                }
                return users;
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT Books.Id, BOOKS.Title, AUTHORS.Id, AUTHORS.Name, GENRES.Id, GENRES.Name, BOOKS.Booked_User, BOOKS.Owner_User FROM BOOKS
                                        LEFT JOIN AUTHORS ON Authors.id = books.AuthorId
                                        LEFT JOIN GENRES ON Genres.id = books.GenreId";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Author = new Author
                                {
                                    Id = reader.GetInt32(2),
                                    Name = reader.GetString(3)
                                },
                                Genre = new Genre
                                {
                                    Id = reader.GetInt32(4),
                                    Name = reader.GetString(5)
                                },
                                BookedUser = reader.GetInt32(6),
                                OwnerUser = reader.GetInt32(7),

                            });
                        }
                    }
                }
                return books;
            }
        }

        public IEnumerable<Book> GetBooksByUser(User user)
        {
            List<Book> books = new List<Book>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT Books.Id, BOOKS.Title, AUTHORS.Id, AUTHORS.Name, GENRES.Id, GENRES.Name, BOOKS.Booked_User, BOOKS.Owner_User FROM BOOKS
                                        LEFT JOIN AUTHORS ON Authors.id = books.AuthorId
                                        LEFT JOIN GENRES ON Genres.id = books.GenreId
                                        WHERE BOOKED_USER=@UserId OR OWNER_USER=@UserId";
                command.Parameters.AddWithValue("UserId", user.Id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Author = new Author
                                {
                                    Id = reader.GetInt32(2),
                                    Name = reader.GetString(3)
                                },
                                Genre = new Genre
                                {
                                    Id = reader.GetInt32(4),
                                    Name = reader.GetString(5)
                                },
                                BookedUser = reader.GetInt32(6),
                                OwnerUser = reader.GetInt32(7),

                            });
                        }
                    }
                }
                return books;
            }
        }

        public void AddBook(Book book)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO BOOKS (Title, AuthorId, GenreId, Booked_User, Owner_User) VALUES (@Title, @AuthorId, @GenreId, 0, 0)";
                command.Parameters.AddWithValue("Title", book.Title);
                command.Parameters.AddWithValue("AuthorId", book.Author.Id);
                command.Parameters.AddWithValue("GenreId", book.Genre.Id);

                command.ExecuteNonQuery();
            }
        }

        public void AddGenre(string text)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO GENRES (NAME) VALUES (@Name)";
                command.Parameters.AddWithValue("Name", text);
                command.ExecuteNonQuery();
            }
        }

        public void AddAuthor(Author author)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO AUTHORS (NAME, DATEOFBIRTH, COUNTRYID) VALUES (@Name, @Date, @CountryId)";
                command.Parameters.AddWithValue("Name", author.Name);
                command.Parameters.AddWithValue("Date", author.DateOfBirth);
                command.Parameters.AddWithValue("CountryId", author.Country.Id);
                command.ExecuteNonQuery();
            }
        }

        public void AddJournalRecord(Journal record)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO JOURNAL (DateOfOperation, UserId, Operation) VALUES (@DateOfOperation, @UserId, @Operation)";
                command.Parameters.AddWithValue("DateOfOperation", record.DateOfOperation);
                command.Parameters.AddWithValue("UserId", record.UserId);
                command.Parameters.AddWithValue("Operation", record.Operation);
                command.ExecuteNonQuery();
            }
        }

        public void EditBook(Book book)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE BOOKS SET Title=@Title, AuthorId=@AuthorId, GenreId=@GenreId, BOOKED_USER=@BookedUser, OWNER_USER=@OwnerUser WHERE Id=@Id";
                command.Parameters.AddWithValue("Id", book.Id);
                command.Parameters.AddWithValue("Title", book.Title);
                command.Parameters.AddWithValue("AuthorId", book.Author.Id);
                command.Parameters.AddWithValue("GenreId", book.Genre.Id);
                command.Parameters.AddWithValue("BookedUser", book.BookedUser);
                command.Parameters.AddWithValue("OwnerUser", book.OwnerUser);
                command.ExecuteNonQuery();
            }
        }

        public void EditGenre(Genre genre)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE GENRES SET Name=@Name WHERE Id=@Id";
                command.Parameters.AddWithValue("Id", genre.Id);
                command.Parameters.AddWithValue("Name", genre.Name);
                command.ExecuteNonQuery();
            }
        }

        public void EditAuthor(Author author)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE BOOKS SET Name=@Name, DateOfBirth=@Date, CountryId=@CountryId WHERE Id=@Id";
                command.Parameters.AddWithValue("Id", author.Id);
                command.Parameters.AddWithValue("Name", author.Name);
                command.Parameters.AddWithValue("Date", author.DateOfBirth);
                command.Parameters.AddWithValue("CountryId", author.Country.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteBook(int bookId)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"DELETE FROM BOOKS WHERE ID=$Id";
                command.Parameters.AddWithValue("$Id", bookId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteGenre(int genreId)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"DELETE FROM GENRES WHERE ID=$Id";
                command.Parameters.AddWithValue("$Id", genreId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAuthor(int authorId)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"DELETE FROM AUTHORS WHERE ID=$Id";
                command.Parameters.AddWithValue("$Id", authorId);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            List<Genre> genres = new List<Genre>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM GENRES ORDER BY NAME";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            genres.Add(new Genre
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                            });
                        }
                    }
                }
                return genres;
            }
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            List<Author> authors = new List<Author>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT AUTHORS.Id, AUTHORS.NAME, AUTHORS.DateOfBirth, COUNTRIES.Id, COUNTRIES.Name FROM AUTHORS
                                        LEFT JOIN COUNTRIES ON COUNTRIES.id = AUTHORS.CountryId";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            authors.Add(new Author
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                DateOfBirth = reader.GetDateTime(2),
                                Country = new Country
                                {
                                    Id = reader.GetInt32(3),
                                    Name = reader.GetString(4)
                                }
                            });
                        }
                    }
                }
                return authors;
            }
        }

        public DataSet GetAuthorsDataset()
        {
            DataSet ds = new DataSet();
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM AUTHORS", connection);
                adapter.Fill(ds);
            }
            return ds;
        }

        public void SaveAuthors(List<Author> authors)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                connection.Open();
                foreach (var author in authors)
                {
                    command.CommandText = "SELECT COUNT (*) FROM AUTHORS WHERE ID = @Id";
                    command.Parameters.AddWithValue("Id", author.Id);
                    
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    if (result > 0)
                    {
                        command.CommandText = @"UPDATE AUTHORS SET Name = @Name, DateOfBirth = @DateOfBirth, CountryId = @CountryId WHERE Id=@Id";
                        command.Parameters.AddWithValue("Name", author.Name);
                        command.Parameters.AddWithValue("DateOfBirth", author.DateOfBirth);
                        command.Parameters.AddWithValue("CountryId", author.Country.Id);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }

                    else
                    {
                        command.CommandText = @"INSERT INTO AUTHORS (Name, DateOfBirth, CountryId) VALUES (@Name, @DateOfBirth, @CountryId)";
                        command.Parameters.AddWithValue("Name", author.Name);
                        command.Parameters.AddWithValue("DateOfBirth", author.DateOfBirth);
                        command.Parameters.AddWithValue("CountryId", author.Country.Id);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
            }
        }

    }
}
