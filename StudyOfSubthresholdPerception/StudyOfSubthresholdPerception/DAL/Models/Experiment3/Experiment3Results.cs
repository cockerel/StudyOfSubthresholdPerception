using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace StudyOfSubthresholdPerception.DAL.Models.Experiment3
{
    public class Experiment3Results
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
        public int Mask { get; set; }
        public int MaskAfter { get; set; }
        public string AnswerRight { get; set; }
    }
}
