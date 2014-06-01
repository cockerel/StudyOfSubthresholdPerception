using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace StudyOfSubthresholdPerception.DAL.Models.Exoeriment4
{
    public class Experiment4Images
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Img { get; set; }
    }
}
