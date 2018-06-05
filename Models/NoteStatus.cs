using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace notepin.api.Models
{
    [Table("note_status")]
    public class NoteStatus
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("code"), MaxLength(5)]
        public string Code { get; set; }

        [Column("name"), MaxLength(30)]
        public string Name { get; set; }

        public NoteStatus()
        {
            
        }
    }
}