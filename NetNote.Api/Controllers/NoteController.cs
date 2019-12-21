using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetNote.IService;
using NetNote.Models;
using NetNote.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetNote.Api.Controllers
{
  [Route("api/note")]
  public class NoteController : ControllerBase
  {
    private INoteRepository _noteRepository;
    private INoteTypeRepository _noteTypeRepository;
    public NoteController(INoteRepository noteRepository, INoteTypeRepository noteTypeRepository)
    {
      _noteRepository = noteRepository;
      _noteTypeRepository = noteTypeRepository;
    }

    // GET: api/values
    [HttpGet]
    public IActionResult Get(int pageindex = 1)
    {
      var pagesize = 5;
      var notes = _noteRepository.PageList(pageindex, pagesize);
      var result = notes.Item1.Select(r => new NoteViewModel
      {
        Id = r.Id,
        Title = string.IsNullOrEmpty(r.Password) ? r.Title : "加密内容",
        Content = string.IsNullOrEmpty(r.Password) ? r.Content : "",
        AttachPath = string.IsNullOrEmpty(r.Password) ? r.Attachment : "",
        TypeName = r.Type.Name
      });
      return Ok(result);

    }
    [HttpGet("{id}")]
    public async Task<IActionResult> Detail(int id, string password)
    {
      var note = await _noteRepository.GetByIdAsync(id);
      if (note == null)
      {
        return NotFound();
      }
      if (!string.IsNullOrEmpty(note.Password) && !note.Password.Equals(password))
      {
        return Unauthorized();
      }
      var result = new NoteViewModel
      {
        Id = note.Id,
        Title = note.Title,
        Content = note.Content,
        AttachPath = note.Attachment,
        TypeName = note.Type.Name
      };
      return Ok(result);
    }
    // POST api/values
    [HttpPost]
    public async Task<IActionResult> Post([FromBody]Note note)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest();
      }
      string filename = string.Empty;
      await _noteRepository.AddAsync(note);
      return CreatedAtAction("Index", "");

    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
