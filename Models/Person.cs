using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace notepin.api.Models
{
    [Table("person")]
    public class Person
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("first_name"), MaxLength(30)]
        public string FirstName { get; set; }

        [Column("last_name"), MaxLength(30)]
        public string LastName { get; set; }

        [Column("username"), MaxLength(30)]
        public string Username { get; set; }

        [Column("password"), MaxLength(500)]
        public string Password { get; set; }

        [Column("profile_id")]
        public int ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; }

        public Person()
        {
            
        }
    }
}