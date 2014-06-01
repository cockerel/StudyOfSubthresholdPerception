using System.ComponentModel.DataAnnotations;

namespace StudyOfSubthresholdPerception.DAL.Models.Exoeriment4
{
    public class Experiment4Settings
    {
        [Key]
        public int Id { get; set; }

        public int CirclePeriod { get; set; }

        public int ExperimentsCount { get; set; }

        public int PointPeriod { get; set; }
    }
}
