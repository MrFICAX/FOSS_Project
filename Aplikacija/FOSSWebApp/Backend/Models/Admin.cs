using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("Admin")]

    public class Admin{
        [Key]
        [Column("IDadmin")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDadmin { get; set; }

        [Column("EnterKey")]
        public string EnterKey { get; set; }

        [Column("AdminName")]
        public string AdminName { get; set; }

        [Column("AdminSurname")]
        public string AdminSurname { get; set; }

        public Organisator GiveAccessBy { get; set; }

        public virtual List<Tournir> Tournirs { get; set; }
    }
}