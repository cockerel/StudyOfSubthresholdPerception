using System.Data.Entity;
using StudyOfSubthresholdPerception.DAL.Models;
using StudyOfSubthresholdPerception.DAL.Models.Experiment2;

namespace StudyOfSubthresholdPerception.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Experiment2> Experiment2Data { get; set; }
        public DbSet<ExperimentsSettings> SettingsData { get; set; }
    }
}
