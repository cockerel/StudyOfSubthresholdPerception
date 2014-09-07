using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DAL;
using StudyOfSubthresholdPerception.DAL.Models.Experiment2;
using StudyOfSubthresholdPerception.DAL.Models.Experiment3;
using StudyOfSubthresholdPerception.Models.Experiment2;

namespace StudyOfSubthresholdPerception.DataHelpers
{
    public class Experiment2DataHelper
    {
        public void AddData(Experiment2DataModel data)
        {
            try
            {
                using (var context = new DataContext())
                {
                    context.Experiment2Data.Add(new Experiment2Data
                    {
                        Id = 0,
                        FirstAnswer = data.FirstAnswer,
                        SecondAnswer = data.SecondAnswer,
                        Image = data.Image,
                        UnderImage = data.UnderImage
                    });
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveData(int id)
        {
            try
            {
                using (var context = new DataContext())
                {

                    var entity = context.Experiment3Data.FirstOrDefault(x => x.Id == id);
                    if (entity != null)
                    {
                        context.Experiment3Data.Remove(entity);
                        var removed = new List<Experiment2SelectedData>();
                        removed.AddRange(context.Experiment2SelectedData.Where(x => x.FirstAnswer == entity.FirstAnswer || x.SecondAnswer == entity.SecondAnswer));
                        foreach (var item in removed)
                        {
                            context.Experiment2SelectedData.Remove(item);
                        }
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveSelectedData(int id)
        {
            try
            {
                using (var context = new DataContext())
                {

                    var entity = context.Experiment2SelectedData.FirstOrDefault(x => x.Id == id);
                    if (entity != null)
                    {
                        context.Experiment2SelectedData.Remove(entity);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddSelectedById(int id)
        {
            try
            {
                using (var context = new DataContext())
                {

                    var entity = context.Experiment2Data.FirstOrDefault(x => x.Id == id);
                    if (entity != null)
                    {
                        context.Experiment2SelectedData.Add(new Experiment2SelectedData { FirstAnswer = entity.FirstAnswer, SecondAnswer = entity.SecondAnswer, Image = entity.Image, UnderImage = entity.UnderImage});
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Experiment2DataModel> GetData()
        {
            var model = new List<Experiment2DataModel>();
            using (var context = new DataContext())
            {
                try
                {
                    model.AddRange(
                        context.Experiment2Data.ToList()
                            .Select(entity => new Experiment2DataModel { Id = entity.Id, FirstAnswer = entity.FirstAnswer, SecondAnswer = entity.SecondAnswer, Image = entity.Image, UnderImage = entity.UnderImage }));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return model;
            }
        }

        public List<Experiment2SelectedData> GetSelectedData()
        {
            var model = new List<Experiment2SelectedData>();
            using (var context = new DataContext())
            {
                try
                {
                    model.AddRange(
                        context.Experiment2SelectedData.ToList()
                            .Select(entity => new Experiment2SelectedData { Id = entity.Id, FirstAnswer = entity.FirstAnswer, SecondAnswer = entity.SecondAnswer, Image = entity.Image, UnderImage = entity.UnderImage}));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return model;
            }
        }


        public Experiment2SettingsModel GetSettings()
        {
            var model = new Experiment2SettingsModel();
            using (var context = new DataContext())
            {
                try
                {
                    var entity = context.Experimen2Settings.FirstOrDefault();
                    if (entity != null)
                    {
                        model.Id = entity.Id;
                        model.ExpCount = entity.ExpCount;
                        model.PresCount = entity.PresCount;
                        model.Interval = entity.Interval;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return model;
            }
        }

        public void SetSettings(Experiment2SettingsModel settings)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var entity = context.Experimen2Settings.FirstOrDefault();
                    if (entity != null)
                        context.Experimen2Settings.Remove(entity);
                    context.Experimen2Settings.Add(new Experiment2Settings
                    {
                        Id = settings.Id,
                        PresCount = settings.PresCount,
                        ExpCount = settings.ExpCount,
                        Interval = settings.Interval,
                        Mask = settings.Mask
                    });
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
