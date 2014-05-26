using System.Drawing;
using System.IO;
using System.Linq;
using StudyOfSubthresholdPerception.DAL;
using StudyOfSubthresholdPerception.DAL.Models.Exoeriment4;
using StudyOfSubthresholdPerception.Models.Experiment4;

namespace StudyOfSubthresholdPerception.DataHelpers
{
	public class Experiment3DataHelper
	{
		public Experiment4ImageModel GetImageById(int id)
		{
			Experiment4ImageModel model = null;
			using (var context = new DataContext())
			{
				var dtoImage = context.Experiment4Images.FirstOrDefault(x => x.Id == id);
				if (dtoImage != null)
				{
					using (var ms = new MemoryStream(dtoImage.Image))
					{
						model = new Experiment4ImageModel { Id = dtoImage.Id, Image = Image.FromStream(ms) };
					}
				}
			}
			return model;
		}

		public void AddImage(Image img)
		{
			Experiment4ImageModel model = null;
			using (var context = new DataContext())
			{
				using (var ms = new MemoryStream())
				{
					img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					var array = ms.ToArray();
					context.Experiment4Images.Add(new Experiment4Images { Image = array });
					context.SaveChanges();
				}
			}
		}
	}
}
