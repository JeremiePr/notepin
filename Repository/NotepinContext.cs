using Microsoft.EntityFrameworkCore;
using notepin.api.Models;

namespace notepin.api.Repository
{
    public class NotepinContext : DbContext
    {
        public NotepinContext(DbContextOptions<NotepinContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Note> Notes { get; set; }

        public virtual DbSet<NoteStatus> NoteStatutes { get; set; }

        public virtual DbSet<Person> Persons { get; set; }

        public virtual DbSet<Profile> Profiles { get; set; }
        
    }
}