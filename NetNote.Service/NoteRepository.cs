using System;
using System.Collections.Generic;using System.Linq;using System.Threading.Tasks;using Microsoft.EntityFrameworkCore;using NetNote.IService;using NetNote.Models;namespace NetNote.Service
{  public class NoteRepository : INoteRepository  {
    private NoteMysqlContext context;    public NoteRepository(NoteMysqlContext _context)    {      this.context = _context;    }    public Task AddAsync(Note note)    {      context.Notes.Add(note);
      return context.SaveChangesAsync();    }    public Task<Note> GetByIdAsync(int Id)    {      return context.Notes.Include(s=>s.Type).FirstOrDefaultAsync(r => r.Id == Id);    }    public Task<List<Note>> GetListAsync()    {      return context.Notes.Include(s => s.Type).ToListAsync();    }    public Tuple<List<Note>, int> PageList(int pageIndex, int pageSize)    {      var query = context.Notes.Include(s => s.Type).AsQueryable();
      var count = query.Count();
      var pageCount = count % pageSize == 0 ? count / pageSize : count / pageSize + 1;
      var notes = query.OrderByDescending(r => r.CreateDate).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
      return new Tuple<List<Note>, int>(notes, pageCount);    }    public Task UpdateAsync(Note note)    {      context.Entry(note).State = EntityState.Modified;
      return context.SaveChangesAsync();    }  }
}
