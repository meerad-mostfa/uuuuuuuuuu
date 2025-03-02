using asp_core.Modles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_Infrastructre.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EF_Task1;Trusted_Connection=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UniversityCompetition>().HasKey(r => new { r.UniversityId, r.CompetitionID });
            modelBuilder.Entity<SponsorComptiition>().HasKey(r => new { r.SponsorID, r.CompetitionID });
            modelBuilder.Entity<TeamsCompetition>().HasKey(r => new { r.TeamId, r.CompetitionID });
            modelBuilder.Entity<TeamsParticipant>().HasKey(r => new { r.TeamId, r.ParticipantId });
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Participant> Participants { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<UniversityCompetition> UniversityCompetitions { get; set; }
        public DbSet<QAA> QAAs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PersonalExperience> PersonalExperiences { get; set; }
        public DbSet<TeamsCompetition> TeamsCompetitions { get; set; }
        public DbSet<TeamsParticipant > TeamsParticipants { get; set; }
        public DbSet<SponsorComptiition> SponsorComptiitions { get; set; }



    }
}
