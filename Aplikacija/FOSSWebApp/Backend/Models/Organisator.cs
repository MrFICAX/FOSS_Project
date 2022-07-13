using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("Organisator")]
    public class Organisator:Person{
        [Column("Pass")]
        public string Pass { get; set; }

        [Column("Username")]
        public string Username { get; set; }

        public virtual List<Tournir> TournirOrganised { get; set;}

        public virtual List<Admin> AdminsCreated { get; set;}
    }
}