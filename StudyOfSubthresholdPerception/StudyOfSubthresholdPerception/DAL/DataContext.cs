using System.Data.Entity;
using StudyOfSubthresholdPerception.DAL.Models.Exoeriment4;
using StudyOfSubthresholdPerception.DAL.Models.Experiment2;
using StudyOfSubthresholdPerception.DAL.Models.Experiment3;

namespace StudyOfSubthresholdPerception.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Experiment2Data> Experiment2Data { get; set; }
        public DbSet<Experiment3Data> Experiment3Data { get; set; }
        public DbSet<Experiment2SelectedData> Experiment2SelectedData { get; set; }
        public DbSet<Experiment3SelectedData> Experiment3SelectedData { get; set; }
        public DbSet<Experiment3Settings> Experimen3Settings { get; set; }
        public DbSet<Experiment2Settings> Experimen2Settings { get; set; }
        public DbSet<Experiment4Settings> Experiment4Settings { get; set; }
        public DbSet<Experiment4Images> Experiment4Images { get; set; }
        public DbSet<Experiment4> Experiment4 { get; set; }
        public DbSet<Experiment3Results> Experiment3Results { get; set; }

        public DataContext()
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }
    }
}
