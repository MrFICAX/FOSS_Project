using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("Referee")]
    public class Referee:Person{
        [Column("Quality")]
        public int Quality { get; set; }
    }
}