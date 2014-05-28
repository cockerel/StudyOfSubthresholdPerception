using System.ComponentModel.DataAnnotations;

namespace StudyOfSubthresholdPerception.DAL.Models.Exoeriment4
{
    public class Experiment4
    {
        [Key]
        public int Id { get; set; }
        public int IdImage1 { get; set; }
        public int IdImage2 { get; set; }
        public int Type { get; set; }
        public bool IsUse { get; set; }
    }
}
