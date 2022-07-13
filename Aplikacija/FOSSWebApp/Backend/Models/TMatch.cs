using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("TMatch")]

    public class TMatch{
        [Key]
        [Column("IDmatch")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDmatch { get; set; }

        [Column("MatchDate")]
        public System.DateTime MatchDate { get; set; }

        [Column("MatchPhase")]
        public string MatchPhase { get; set; }

        [Column("Live")]
        public bool Live { get; set; }

        [Column("HomeGoals")]
        public int HomeGoals { get; set; }

        [Column("AwayGoals")]
        public int AwayGoals { get; set; }

        [Column("Winner")]
        public Club Winner { get; set; }

        [Column("SpecificNumber")]
        public string SpecificNumber { get; set; }

        public Referee Refereee { get; set; }

        public Tournir TournirM { get; set; }
        
        public Club Club1 { get; set; }

        public Club Club2 { get; set; }
    }
}