using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;

namespace OnionApp.Infrastructure.Data
{
    public class BookRepository : IBookRepository
    {
        private OrderContext db;

        public BookRepository()
        {
            this.db = new OrderContext();
        }

        public IEnumerable<Book> GetBookList()
        {
            return db.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return db.Books.Find(id);
        }

        public void Create(Book book)
        {
            db.Books.Add(book);
        }

        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Book book = db.Books.Find(id);
            if (book != null)
                db.Books.Remove(book);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
