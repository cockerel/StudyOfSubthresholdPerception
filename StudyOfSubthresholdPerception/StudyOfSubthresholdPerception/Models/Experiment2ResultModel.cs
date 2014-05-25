using System;
using System.Collections.Generic;

namespace StudyOfSubthresholdPerception.Models
{
    public class Experiment2ResultModel
    {
        public List<int> SelectedImageIds { get; set; }
        public DateTime Time { get; set; }

        public Experiment2ResultModel()
        {
            SelectedImageIds = new List<int>();
        }
    }
}
