using System;
using System.Collections.Generic;
using apilibrary.Services;
using apilibrary.models;

using Microsoft.AspNetCore.Mvc;
using apilibrary.db;

namespace apilibrary.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class BooksController : ControllerBase
  {
    private readonly BooksService _service;

    public BooksController(BooksService service)
    {
      _service = service;
    }

    [HttpGet("{name}")]
    public ActionResult<Book> GetById([FromBody] Book newBook)
    {
      try
      {
        Console.Beep();
        return Ok(_service.GetById(newBook));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
    [HttpGet]

    public ActionResult<IEnumerable<Book>> GetAll()
    {
      try
      {
        return Ok(_service.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Book> Create([FromBody] Book newBook)
    {
      try
      {


        return Ok(_service.Create(newBook));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{name}")]
    public ActionResult<Book> Delete(string name)
    {
      try
      {
        return Ok(_service.Delete(name));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Book> Edit([FromBody] Book newBook)
    {
      try
      {
        return Ok(_service.Edit(name));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
