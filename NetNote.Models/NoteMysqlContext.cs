using System;
using Microsoft.EntityFrameworkCore;

namespace NetNote.Models
{
  public class NoteMysqlContext:DbContext
  {
    public NoteMysqlContext(DbContextOptions<NoteMysqlContext> options) : base(options)    {    }
    public DbSet<Note> Notes { get; set; }    public DbSet<NoteType> NoteTypes { get; set; }
  }
}
