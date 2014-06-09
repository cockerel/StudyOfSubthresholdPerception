using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DAL;
using StudyOfSubthresholdPerception.DAL.Models.Exoeriment4;
using StudyOfSubthresholdPerception.DAL.Models.Experiment3;
using StudyOfSubthresholdPerception.Models.Experiment2;
using StudyOfSubthresholdPerception.Models.Experiment3;
using StudyOfSubthresholdPerception.Models.Experiment4;

namespace StudyOfSubthresholdPerception.DataHelpers
{
    public class Experiment3DataHelper
    {
        public void AddData(Experiment3DataModel data)
        {
            try
            {
                using (var context = new DataContext())
                {

                    context.Experiment3Data.Add(new Experiment3Data { Id = 0, FirstAnswer = data.FirstAnswer, SecondAnswer = data.SecondAnswer, Text = data.Text });
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
						var removed = new List<Experiment3SelectedData>();
						removed.AddRange(context.Experiment3SelectedData.Where(x => x.FirstAnswer == entity.FirstAnswer || x.SecondAnswer == entity.SecondAnswer));
						foreach (var item in removed)
						{
							context.Experiment3SelectedData.Remove(item);
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

                    var entity = context.Experiment3SelectedData.FirstOrDefault(x => x.Id == id);
                    if (entity != null)
                    {
                        context.Experiment3SelectedData.Remove(entity);
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

                    var entity = context.Experiment3Data.FirstOrDefault(x => x.Id == id);
                    if (entity != null)
                    {
                        context.Experiment3SelectedData.Add(new Experiment3SelectedData { FirstAnswer = entity.FirstAnswer, SecondAnswer = entity.SecondAnswer, Text = entity.Text });
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Experiment3DataModel> GetData()
        {
            var model = new List<Experiment3DataModel>();
            using (var context = new DataContext())
            {
                try
                {
                    model.AddRange(
                        context.Experiment3Data.ToList()
                            .Select(entity => new Experiment3DataModel { Id = entity.Id, FirstAnswer = entity.FirstAnswer, SecondAnswer = entity.SecondAnswer, Text = entity.Text }));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return model;
            }
        }

        public List<Experiment3SelectedData> GetSelectedData()
        {
            var model = new List<Experiment3SelectedData>();
            using (var context = new DataContext())
            {
                try
                {
                    model.AddRange(
                        context.Experiment3SelectedData.ToList()
                            .Select(entity => new Experiment3SelectedData { Id = entity.Id, FirstAnswer = entity.FirstAnswer, SecondAnswer = entity.SecondAnswer, Text = entity.Text }));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return model;
            }
        }


        public Experiment3SettingsModel GetSettings()
        {
            var model = new Experiment3SettingsModel();
            using (var context = new DataContext())
            {
                try
                {
                    var entity = context.Experimen3Settings.FirstOrDefault();
                    if (entity != null)
                    {
                        model.Id = entity.Id;
                        model.ExpCount = entity.ExpCount;
                        model.PresCount = entity.PresCount;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return model;
            }
        }

        public void SetSettings(Experiment3SettingsModel settings)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var entity = context.Experimen3Settings.FirstOrDefault();
                    if (entity != null)
                        context.Experimen3Settings.Remove(entity);
                    context.Experimen3Settings.Add(new Experiment3Settings
                    {
                        Id = settings.Id,
                        PresCount = settings.PresCount,
                        ExpCount = settings.ExpCount
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
