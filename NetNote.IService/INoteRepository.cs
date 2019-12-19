using System;
using System.Collections.Generic;using System.Threading.Tasks;using NetNote.Models;namespace NetNote.IService
{  public interface INoteRepository  {    Task<Note> GetByIdAsync(int Id);
    Task<List<Note>> GetListAsync();
    Task AddAsync(Note note);
    Task UpdateAsync(Note note);
    Tuple<List<Note>, int> PageList(int pageIndex, int pageSize);  }
}
