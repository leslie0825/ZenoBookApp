using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Data.DTOs;

namespace Data.Repositories
{
    internal class BooksRepository : RepositoryBase, IBooksRepository
    {
        public BooksRepository(IDbConnection connection)
            : base(connection)
        {
        }

        public IEnumerable<GetBooksDTO> GetBooks()
        {
            return Connection.Query<GetBooksDTO>(@"SELECT BookName = Books.Name, Author = Authors.Name + ' ' + Authors.Surname, Books.Genre FROM Books 
                            INNER JOIN Authors ON Books.AuthorId = Authors.Id ");
        }

        public IEnumerable<GetBooksDTO> SearchBooks(string book)
        {
            return Connection.Query<GetBooksDTO>(@"SELECT BookName = Books.Name, Author = Authors.Name + ' ' + Authors.Surname, Books.Genre FROM Books 
                            INNER JOIN Authors ON Books.AuthorId = Authors.Id WHERE Books.Name LIKE CONCAT('%',@book,'%')",  new { book });
        }

        public void InsertBook(DTOs.InsertBookDTO book)
        {
            Connection.Execute(@"INSERT INTO Books(Name,AuthorId,Genre) VALUES(@Name,@AuthorId,@Genre)", param: new { Name = book.BookName, Genre = book.Genre, AuthorId = book.AuthorId });
        }

      
    }
}
