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
        public void AddDataRecord(Experiment2Model record)
        {
            using (var context = new DataContext())
            {
                context.Experiment2Data.Add(new Experiment3 { Id = record.Id, Text = record.Text });
                context.SaveChanges();
            }
        }

        public void AddDataRecordsRange(IEnumerable<Experiment2Model> records)
        {
            using (var context = new DataContext())
            {
                var entity = records.Select(x => new Experiment3 { Id = x.Id, Text = x.Text });
                context.Experiment2Data.AddRange(entity);
                context.SaveChanges();
            }
        }

        public void RemoveRangeRecords(IEnumerable<Experiment2Model> records)
        {
            using (var context = new DataContext())
            {
                var entity = records.Select(x => new Experiment3 { Id = x.Id, Text = x.Text });
                context.Experiment2Data.RemoveRange(entity);
                context.SaveChanges();
            }
        }

    }
}
