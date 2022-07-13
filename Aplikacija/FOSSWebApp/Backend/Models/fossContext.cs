using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Backend.Models{
    public class fossContext: DbContext{
        public DbSet<Admin> Admins { get; set;}
        public DbSet<Club> Clubs { get; set;}
        public DbSet<Organisator> Organisators { get; set;}
        public DbSet<Person> People { get; set;}
        public DbSet<Player> Players { get; set;}
        public DbSet<Referee> Referees { get; set;}
        public DbSet<TMatch> Tmatches { get; set;}
        public DbSet<Tournir> Tournirs { get; set;}
        public DbSet<Trainer> Trainers { get; set;}
        public DbSet<ClubStatistic> ClubStatistics { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        public fossContext(DbContextOptions options):base(options){}
}
}