using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models{
    [Table("Trainer")]
    public class Trainer:Person{

        //public Club TrainerOfClub { get; set; }
    }
}