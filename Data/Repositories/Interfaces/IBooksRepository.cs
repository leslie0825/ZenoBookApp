using Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IBooksRepository
    {
        IEnumerable<GetBooksDTO> GetBooks();
        IEnumerable<GetBooksDTO> SearchBooks(string book);
        void InsertBook(InsertBookDTO book);
    }
}
