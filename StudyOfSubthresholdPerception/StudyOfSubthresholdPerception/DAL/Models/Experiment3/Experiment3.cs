using System.ComponentModel.DataAnnotations;

namespace StudyOfSubthresholdPerception.DAL.Models.Experiment3
{
    public class Experiment3
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Text { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstAnswer { get; set; }

        [Required]
        [StringLength(100)]
        public string SecondAnswer { get; set; }
    }
}
