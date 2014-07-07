using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace StudyOfSubthresholdPerception.DAL.Models.Experiment2
{
    public class Experiment2Data
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] UnderImage { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstAnswer { get; set; }

        [Required]
        [StringLength(100)]
        public string SecondAnswer { get; set; }
    }
}
