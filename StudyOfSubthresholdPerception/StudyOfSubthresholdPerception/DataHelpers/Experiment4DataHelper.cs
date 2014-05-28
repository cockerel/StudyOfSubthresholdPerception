using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DAL;
using StudyOfSubthresholdPerception.DAL.Models.Exoeriment4;
using StudyOfSubthresholdPerception.Models.Experiment4;

namespace StudyOfSubthresholdPerception.DataHelpers
{
    public class Experiment4DataHelper
    {
        public Experiment4ImageModel GetImageById(int id)
        {
            Experiment4ImageModel model = null;
            using (var context = new DataContext())
            {
                var dtoImage = context.Experiment4Images.FirstOrDefault(x => x.Id == id);
                if (dtoImage != null)
                {
                    using (var ms = new MemoryStream(dtoImage.Img))
                    {
                        model = new Experiment4ImageModel { Id = dtoImage.Id, Img = Image.FromStream(ms) };
                    }
                }
            }
            return model;
        }

        public List<Experiment4ImageModel> GetAll()
        {
            var model = new List<Experiment4ImageModel>();
            using (var context = new DataContext())
            {
                foreach (var entity in context.Experiment4Images)
                {
                    using (var ms = new MemoryStream(entity.Img))
                    {
                        model.Add(new Experiment4ImageModel{Id = entity.Id, Img = Image.FromStream(ms)});
                    }
                }
                return model;
            }
        }

        public void AddImage(Image img)
        {
            try
            {
                using (var context = new DataContext())
                {
                    using (var ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        context.Experiment4Images.Add(new Experiment4Images { Id = 0, Img = ms.ToArray() });
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
