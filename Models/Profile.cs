using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace notepin.api.Models
{
    [Table("profile")]
    public class Profile
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("name"), MaxLength(50)]
        public string Name { get; set; }

        [Column("is_administrator")]
        public bool IsAdministrator { get; set; }

        public Profile()
        {
            
        }
    }
}