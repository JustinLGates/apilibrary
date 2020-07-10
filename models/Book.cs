
using System;
using System.Collections.Generic;
namespace apilibrary.models
{
  public class Book
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public Book(string name, string id)
    {
      Name = name;
      Id = id;
    }
    public Book()
    {

    }

  }
}