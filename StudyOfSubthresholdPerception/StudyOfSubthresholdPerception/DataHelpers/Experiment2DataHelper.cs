using System.Collections.Generic;
using System.Linq;
using StudyOfSubthresholdPerception.DAL;
using StudyOfSubthresholdPerception.DAL.Models.Experiment3;
using StudyOfSubthresholdPerception.Models;
using StudyOfSubthresholdPerception.Models.Experiment2;

namespace StudyOfSubthresholdPerception.DataHelpers
{
    public class Experiment2DataHelper
    {
        public void AddDataRecord(Experiment3Model record)
        {
            using (var context = new DataContext())
            {
               // var model = context.Experiment3Data.Select(x=>new Experiment3Model{Id = x.Id, FirstAnswer = x.FirstAnswer, Text = x.Text, SecondAnswer = x.SecondAnswer});
                var model = new List<Experiment3Model>();
                foreach (var entity in context.Experiment3Data)
                {
                    model.Add(new Experiment3Model{Id = entity.Id, Text = entity.Text, SecondAnswer = entity.SecondAnswer, FirstAnswer = entity.FirstAnswer});
                }
                context.SaveChanges();
            }
        }

        public void AddDataRecordsRange(IEnumerable<Experiment3Model> records)
        {
            using (var context = new DataContext())
            {
                var entity = records.Select(x => new Experiment3 { Id = x.Id, Text = x.Text });
                context.Experiment3Data.AddRange(entity);
                context.SaveChanges();
            }
        }

        public void RemoveRangeRecords(IEnumerable<Experiment3Model> records)
        {
            using (var context = new DataContext())
            {
                var entity = records.Select(x => new Experiment3 { Id = x.Id, Text = x.Text });
                context.Experiment3Data.RemoveRange(entity);
                context.SaveChanges();
            }
        }

    }
}
