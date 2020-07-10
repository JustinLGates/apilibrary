using System.Collections.Generic;
using apilibrary.models;

namespace apilibrary.db
{

  public static class Db
  {

    public static List<Book> Books { get; set; } = new List<Book>(){
            new Book("dictionary"),
            new Book("c# for idiots"),
            new Book("C# for normal people")
        };


  }
}