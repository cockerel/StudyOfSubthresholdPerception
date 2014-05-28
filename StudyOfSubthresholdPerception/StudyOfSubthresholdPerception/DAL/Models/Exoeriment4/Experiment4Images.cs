using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace StudyOfSubthresholdPerception.DAL.Models.Exoeriment4
{
    public class Experiment4Images
    {
        [Key]
        public int Id { get; set; }
        public byte[] Img { get; set; }
    }
}
