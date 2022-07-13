using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("Person")]
    public class Person{
        [Key]
        [Column("IDperson")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDperson { get; set; }

        [Column("PersonName")]
        public string PersonName { get; set; }

        [Column("Surname")]
        public string Surname { get; set; }

        [Column("BornDate")]
        public string BornDate { get; set; }   
    }
}