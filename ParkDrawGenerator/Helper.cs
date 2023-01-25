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
	}
}