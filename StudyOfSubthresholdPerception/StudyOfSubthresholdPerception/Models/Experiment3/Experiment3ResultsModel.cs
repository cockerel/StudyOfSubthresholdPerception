using System;

namespace StudyOfSubthresholdPerception.Models.Experiment3
{
    public class Experiment3ResultsModel
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string AnswerRight { get; set; }
        public string Incentive { get; set; }
        public DateTime Date { get; set; }
        public int ExperimentsCount { get; set; }
        public int PresentationTime { get; set; }
        public bool IsRight { get; set; }
        public int Mask { get; set; }
        public int MaskAfter { get; set; }
        public int UserId { get; set; }
    }
}
