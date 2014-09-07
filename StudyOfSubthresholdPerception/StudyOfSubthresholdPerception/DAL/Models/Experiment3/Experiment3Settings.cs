using System.ComponentModel.DataAnnotations;

namespace StudyOfSubthresholdPerception.DAL.Models.Experiment3
{
    public class Experiment3Settings
    {
        [Key]
        public int Id { get; set; }
        public int ExpCount { get; set; }
        public int PresCount { get; set; }
        public int Interval { get; set; }
        public int Mask { get; set; }
    }
}
