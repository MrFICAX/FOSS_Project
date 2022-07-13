using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("PlayerStatistic")]

    public class PlayerStatistic{
        [Key]
        [Column("IDpstatistic")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDpstatistic { get; set; }

        [Column("Goals")]
        public int Goals { get; set; }

        [Column("Cards")]
        public int Cards { get; set; }

        public Player PlayerStat { get; set; }

        public Tournir TournirStatP { get; set; }
    }
}