﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
				foreach (var entity in context.Experiment4Images.ToList())
				{
					using (var ms = new MemoryStream(entity.Img))
					{
						model.Add(new Experiment4ImageModel { Id = entity.Id, Img = Image.FromStream(ms) });
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
		public void AddData(Experiment4Model data)
		{
			try
			{
				using (var context = new DataContext())
				{

					context.Experiment4.Add(new Experiment4 { Id = 0, IdImage1 = data.Id1, IdImage2 = data.Id2 });
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public List<Experiment4Model> GetData()
		{
			var model = new List<Experiment4Model>();
			using (var context = new DataContext())
			{
				try
				{
					model.AddRange(
						context.Experiment4.ToList()
							.Select(entity => new Experiment4Model { Id = entity.Id, Id1 = entity.IdImage1, Id2 = entity.IdImage2, ImageItem1 = GetImageById(entity.IdImage1).Img, ImageItem2 = GetImageById(entity.IdImage2).Img }));
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
				}
				return model;
			}
		}

		public Experiment4SettingsModel GetSettings()
		{
			var model = new Experiment4SettingsModel();
			using (var context = new DataContext())
			{
				try
				{
					var entity = context.Experiment4Settings.FirstOrDefault();
					if (entity != null)
					{
						model.Period = entity.Period;
						model.Presentations = entity.PresentationCount;
					}
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
				}
				return model;
			}
		}

		public void SetSettings(Experiment4SettingsModel settings)
		{
			using (var context = new DataContext())
			{
				try
				{
					var entity = context.Experiment4Settings.FirstOrDefault();
					if(entity!=null)
					context.Experiment4Settings.Remove(entity);
					context.Experiment4Settings.Add(new Experiment4Settings
					{
						PresentationCount = settings.Presentations,
						Period = settings.Period
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
