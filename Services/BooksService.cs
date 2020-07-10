
using apilibrary.db;
using System;
using apilibrary.models;
using System.Collections.Generic;
namespace apilibrary.Services
{
  public class BooksService
  {
    internal IEnumerable<Book> Get()
    {
      return Db.Books;
    }
    internal Book GetById(Book book)
    {
      return Db.Books.Find((b) => b.Name == book.Name); ;
    }
    internal Book Create(Book newBook)
    {
      Db.Books.Add(newBook);
      return newBook;
    }
    internal string Delete(string name)
    {
      Console.Beep();
      Book book = Db.Books.Find(b => b.Name == name);
      Db.Books.Remove(book);
      return "success";
    }
    internal string Edit(string name)
    {
      Book book = Db.Books.Find(b => b.Name == name);

    }
  }
}