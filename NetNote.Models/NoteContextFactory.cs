using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetNote.Models
{
  public class NoteContextFactory : IDesignTimeDbContextFactory<NoteContext>
  {
    public NoteContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<NoteContext>();
      optionsBuilder.UseSqlServer("server=localhost;uid=sa;pwd=123456;database=NoteDb;");

      return new NoteContext(optionsBuilder.Options);
    }
  }
}
