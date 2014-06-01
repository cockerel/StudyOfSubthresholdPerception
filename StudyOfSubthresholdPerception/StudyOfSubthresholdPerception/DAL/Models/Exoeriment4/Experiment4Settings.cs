using System.ComponentModel.DataAnnotations;

namespace StudyOfSubthresholdPerception.DAL.Models.Exoeriment4
{
    public class Experiment4Settings
    {
        [Key]
        public int Id { get; set; }

        public int PresentationCount { get; set; }

        public int ExperimentsCount { get; set; }
		public int Period { get; set; }
        public int PresentationTrainingCount { get; set; }
    }
}
