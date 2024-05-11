using Microsoft.AspNetCore.Mvc;

using gerenciadorlivrariacsharp.Communication.Response;
using gerenciadorlivrariacsharp.Entity;

namespace GerenciadorLivrariaCSharp.Controllers;

public class BookController : GerenciadorLivrariaCSharpBaseController
{
    [HttpPost()]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] BookEntity request)
    {
        Guid _Id = BookListEntity.Add(request);

        ResponseRegisterBookJson response = new ResponseRegisterBookJson {
            Id = _Id,
            Title = request.Title,
            Author = request.Author,
            Gender = (int)request.Gender,
            Price = request.Price
        };
        
        return Created("", response);
    }
    
    [HttpGet()]
    [ProducesResponseType(typeof(List<BookEntity>), StatusCodes.Status200OK)]
    public IActionResult Index()
    {
        return Ok(BookListEntity.books.Values);
    }
    
    [HttpPut()]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] Guid Id, [FromBody] BookEntity request)
    {
        BookListEntity.Update(Id, request);
    
        return NoContent();
    }
    
    [HttpDelete()]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] Guid Id)
    {
        BookListEntity.Delete(Id);
    
        return NoContent();
    }

}
