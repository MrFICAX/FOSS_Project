using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Backend.Models{
    [Table("Player")]

    public class Player: Person{
        [Column("Num")]
        public int Num { get; set; }

        [Column("Captain")]
        public bool Captain { get; set; }

        [Column("Position")]
        public string Position { get; set; }     

        public Club ClubPlayingFor { get; set; }

        public virtual List<PlayerStatistic> PlayerStatistics {get; set;}   
    }
}