using System.Data.Entity;
using StudyOfSubthresholdPerception.DAL.Models;
using StudyOfSubthresholdPerception.DAL.Models.Exoeriment4;
using StudyOfSubthresholdPerception.DAL.Models.Experiment3;

namespace StudyOfSubthresholdPerception.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Experiment3> Experiment3Data { get; set; }
        public DbSet<ExperimentsSettings> SettingsData { get; set; }
		public DbSet<Experiment4Images> Experiment4Images { get; set; }
        public DbSet<Experiment4> Experiment4{ get; set; }
    }
}
