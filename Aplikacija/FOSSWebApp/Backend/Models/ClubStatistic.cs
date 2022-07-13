using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("ClubStatistic")]

    public class ClubStatistic{
        [Key]
        [Column("IDcstatistic")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDcstatistic { get; set; }

        [Column("Wins")]
        public int Wins { get; set; }

        [Column("Loses")]
        public int Loses { get; set; }

        [Column("Draws")]
        public int Draws { get; set; }

        [Column("GoalsDifference")]
        public int GoalsDifference { get; set; }

        public Tournir TournirStatC { get; set; }

        public Club ClubStat { get; set; }
    }
}