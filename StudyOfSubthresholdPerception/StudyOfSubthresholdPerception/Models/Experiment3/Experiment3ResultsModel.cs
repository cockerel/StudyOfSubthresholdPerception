using System;

namespace StudyOfSubthresholdPerception.Models.Experiment3
{
    public class Experiment3ResultsModel
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public DateTime Date { get; set; }
        public int ExperimentsCount { get; set; }
        public int PresentationTime { get; set; }
        public bool IsRight { get; set; }
    }
}
