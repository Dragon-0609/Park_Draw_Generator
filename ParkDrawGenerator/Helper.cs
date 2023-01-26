using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ParkDrawGenerator
{
	public static class Helper
	{
		private static Dictionary<Brush, Color> _colors = new()
		{
			{ Brush.Unset, SystemColors.Control },
			{ Brush.Red, Color.Red },
			{ Brush.Green, Color.Green },
			{ Brush.Blue, Color.Blue },
			{ Brush.Yellow, Color.Yellow },
		};

		private static Dictionary<Destination, Image> _destinations = new()
		{
			{ Destination.Unset, null },
			{ Destination.Arrow, Properties.Resources.Arrow__2_ },
			{ Destination.Park, Properties.Resources.Parking__2_ },
			{ Destination.Button, Properties.Resources.button_red },
		};

		private static Dictionary<Rotating, Image> _rotatings = new()
		{
			{ Rotating.Unset, null },
			{ Rotating.TurningLeftSW, Properties.Resources.Turn_arrow },
			{ Rotating.TurningLeftES, Properties.Resources.Turn_arrow_left_es },
			{ Rotating.TurningLeftNE, Properties.Resources.Turn_arrow_left_ne },
			{ Rotating.TurningLeftWN, Properties.Resources.Turn_arrow_left_wn },
			{ Rotating.TurningRightSE, Properties.Resources.Turn_arrow_right },
			{ Rotating.TurningRightEN, Properties.Resources.Turn_arrow_right_en },
			{ Rotating.TurningRightNW, Properties.Resources.Turn_arrow_right_nw },
			{ Rotating.TurningRightWS, Properties.Resources.Turn_arrow_right_se },
		};

		private static Dictionary<Rotating, int> _rotating_ints = new()
		{
			{ Rotating.TurningLeftSW, 6 },
			{ Rotating.TurningLeftES, 12 },
			{ Rotating.TurningLeftNE, 9 },
			{ Rotating.TurningLeftWN, 3 },
			{ Rotating.TurningRightSE, 12 },
			{ Rotating.TurningRightEN, 9 },
			{ Rotating.TurningRightNW, 3 },
			{ Rotating.TurningRightWS, 6 },
		};

		private static Dictionary<Barrier, Image> _barriers = new()
		{
			{ Barrier.Unset, null },
			{ Barrier.Barrier, Properties.Resources.Barrier },
		};

		internal static Color GetColor(this Brush brush)
		{
			return _colors[brush];
		}

		internal static Brush ToBrush(this Color color)
		{
			return _colors.ContainsValue(color) ? _colors.First(col => col.Value == color).Key : Brush.Unset;
		}

		internal static Image GetImage(this Destination destination)
		{
			return _destinations[destination];
		}

		internal static Image GetImage(this Rotating destination)
		{
			return _rotatings[destination];
		}

		internal static bool IsToRight(this Rotating rotating)
		{
			return rotating is Rotating.TurningRightEN or Rotating.TurningRightNW or Rotating.TurningRightSE or Rotating.TurningRightWS;
		}

		internal static bool IsToSorToN(this Rotating rotating)
		{
			if (rotating.IsToRight())
			{
				return rotating is Rotating.TurningRightEN or Rotating.TurningRightWS;
			}

			return rotating is Rotating.TurningLeftES or Rotating.TurningLeftWN;
		}

		internal static int ToInt(this Rotating rotating)
		{
			return _rotating_ints.ContainsKey(rotating) ? _rotating_ints[rotating] : 0;
		}

		internal static Image GetImage(this Barrier barrier)
		{
			return _barriers[barrier];
		}
		
		public static Bitmap CombineBitmap(this Image[] files)
        {
	        List<Bitmap> images = new List<Bitmap>();
	        int maxW = 0, maxH = 0;
	        foreach (Image image in files)
	        {
		        if (image != null)
		        {
			        Bitmap bitmap = new Bitmap(image);
			        maxW = Math.Max(bitmap.Size.Width, maxW);
			        maxH = Math.Max(bitmap.Size.Height, maxH);
			        images.Add(bitmap);
		        }
	        }  
	        if (images.Count > 1)
	        {
		        Bitmap finalImage = new Bitmap(maxW, maxH);

		        using (Graphics g = Graphics.FromImage(finalImage))
		        {
			        // g.Clear(Color.Black);
			        foreach (Bitmap image in images)
			        {
				        g.DrawImage(image, new Rectangle(0, 0, maxW, maxH));
			        }
		        }

		        images.Clear();
		        return finalImage;
	        }else if (images.Count == 1)
	        {
		        return images[0];
	        }

	        return null;
        }
	}
}