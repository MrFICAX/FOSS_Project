using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("Tournir")]

    public class Tournir{
        [Key]
        [Column("IDtournir")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDtournir { get; set; }

        [Column("TournirName")]
        public string TournirName { get; set; }

        [Column("Form")]
        public string Form { get; set; }
        
        [Column("City")]
        public string City { get; set; }

        [Column("TournirWinner")]
        public string TournirWinner { get; set; }

        [Column("TournirDate")]
        public System.DateTime TournirDate { get; set; }

        [Column("WinnersPerGroup")]
        public int WinnersPerGroup { get; set; }

        [Column("NumOfTeamsPerGroup")]
        public int NumOfTeamsPerGroup { get; set; }
        public virtual List<TMatch> TMatches { get; set; }

        public virtual List<Admin> Admins { get; set; }

        public virtual List<Club> Clubs { get; set; }

        public virtual List<ClubStatistic> ClubsStatistics { get; set; }

        public virtual List<PlayerStatistic> PlayerStatistics { get; set; }

        public Organisator TournirOrganisator { get; set; }
    }
}