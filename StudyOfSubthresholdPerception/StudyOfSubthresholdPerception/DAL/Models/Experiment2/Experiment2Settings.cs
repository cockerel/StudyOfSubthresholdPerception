using System.ComponentModel.DataAnnotations;

namespace StudyOfSubthresholdPerception.DAL.Models.Experiment2
{
    public class Experiment2Settings
    {
        [Key]
        public int Id { get; set; }
        public int ExpCount { get; set; }
        public int PresCount { get; set; }
        public int Interval { get; set; }
    }
}
