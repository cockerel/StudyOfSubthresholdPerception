using System.ComponentModel.DataAnnotations;

namespace StudyOfSubthresholdPerception.DAL.Models
{
    public class ExperimentsSettings
    {
        [Key]
        public int Id { get; set; }

        public int PresentationCount { get; set; }

        public int ExperimentsCount { get; set; }

        [Required]
        [StringLength(100)]
        public string ExperimentId { get; set; }
    }
}
