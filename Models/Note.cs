using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace notepin.api.Models
{
    [Table("note")]
    public class Note
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("title"), MaxLength(30)]
        public string Title { get; set; }

        [Column("text"), MaxLength(1000)]
        public string Text { get; set; }

        [Column("note_date")]
        public DateTime? NoteDate { get; set; }

        [Column("person_id")]
        public int? PersonId { get; set; }

        [Column("note_status_id")]
        public int NoteStatusId { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        [ForeignKey("NoteStatusId")]
        public NoteStatus NoteStatus { get; set; }

        public Note()
        {
            
        }
    }
}