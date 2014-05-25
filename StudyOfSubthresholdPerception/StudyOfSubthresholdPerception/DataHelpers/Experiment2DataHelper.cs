using System.Collections.Generic;
using System.Linq;
using StudyOfSubthresholdPerception.DAL;
using StudyOfSubthresholdPerception.DAL.Models;
using StudyOfSubthresholdPerception.DAL.Models.Experiment2;
using StudyOfSubthresholdPerception.Models;

namespace StudyOfSubthresholdPerception.DataHelpers
{
    public class Experiment2DataHelper
    {
        public void AddDataRecord(Experiment2Model record)
        {
            using (var context = new DataContext())
            {
                context.Experiment2Data.Add(new Experiment2 { Id = record.Id, Text = record.Text });
                context.SaveChanges();
            }
        }

        public void AddDataRecordsRange(IEnumerable<Experiment2Model> records)
        {
            using (var context = new DataContext())
            {
                var entity = records.Select(x => new Experiment2 { Id = x.Id, Text = x.Text });
                context.Experiment2Data.AddRange(entity);
                context.SaveChanges();
            }
        }

        public void RemoveRangeRecords(IEnumerable<Experiment2Model> records)
        {
            using (var context = new DataContext())
            {
                var entity = records.Select(x => new Experiment2 { Id = x.Id, Text = x.Text });
                context.Experiment2Data.RemoveRange(entity);
                context.SaveChanges();
            }
        }

    }
}
