using System;
using System.ComponentModel.DataAnnotations;
namespace StudyOfSubthresholdPerception.DAL.Models.Experiment2
{
    public class Experiment2Results
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer { get; set; }
        public int UserId { get; set; }
        public string Incentive { get; set; }
        public DateTime Date { get; set; }
        public int ExperimentsCount { get; set; }
        public int PresentationTime { get; set; }
        public bool IsRight { get; set; }
    }
}
