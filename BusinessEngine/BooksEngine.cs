using Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEngine
{
    public class BooksEngine : EngineBase
    {

        public List<GetBooksDTO> GetBooks()
        {
            try
            {
                var books = UnitOfWork.BooksRepository.GetBooks();
                UnitOfWork.Dispose();
                return books.ToList();
            }
            catch (Exception ex)
            {
                //LOG vs.
                return new List<GetBooksDTO>();
            }
        }

        public List<GetBooksDTO> SearchBooks(string book)
        {
            try
            {
                var books = UnitOfWork.BooksRepository.SearchBooks(book);
                UnitOfWork.Dispose();
                return books.ToList();
            }
            catch (Exception ex)
            {
                //LOG vs.
                return new List<GetBooksDTO>();
            }
        }
        public void InsertBook(InsertBookDTO book)
        {
            try
            {
                UnitOfWork.BooksRepository.InsertBook(book);
                UnitOfWork.Dispose();
            }
            catch (Exception ex)
            {
                //LOG vs.
            }
        }
    }
}
