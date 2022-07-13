using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("Club")]

    public class Club{
        [Key]
        [Column("IDclub")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDclub { get; set; } 

        [Column("ClubName")]
        public string ClubName { get; set; }

        public virtual List<Player> Players { get; set; }
        
        public Trainer Trainer { get; set; }

        public virtual List<Tournir> TournirsPlayingIn { get; set; }

        [NotMapped]
        public virtual List<TMatch> MatchesPlayed { get; set; }

        public virtual List<ClubStatistic> EveryClubStatistics { get; set;}
    }
}