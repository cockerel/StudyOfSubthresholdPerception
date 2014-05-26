using System.ComponentModel.DataAnnotations;

namespace StudyOfSubthresholdPerception.DAL.Models.Exoeriment4
{
	public class Experiment4Images
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public byte[] Image { get; set; }
	}
}
