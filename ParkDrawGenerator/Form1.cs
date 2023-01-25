using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Point = ParkDrawGenerator.Point;

namespace ParkDrawGenerator
{
	public partial class Form1 : Form
	{
		private int _x = 2, _y = 2;
		private const int TileSize = 40;
		public Brush Brush = Brush.Unset;
		public Destination Destination = Destination.Unset;
		public Rotating Rotating = Rotating.Unset;
		private Dictionary<Point, Brush> _brushes = new Dictionary<Point, Brush>();
		private Dictionary<Point, Destination> _destinations = new Dictionary<Point, Destination>();
		private Dictionary<Point, Rotating> _rotatings = new Dictionary<Point, Rotating>();

		public Form1()
		{
			InitializeComponent();
			InitializeBoard();
		}

		private void XInput_ValueChanged(object sender, EventArgs e)
		{
			_x = Convert.ToInt32(XInput.Value);
			InitializeBoard();
		}

		private void YInput_ValueChanged(object sender, EventArgs e)
		{
			_y = Convert.ToInt32(YInput.Value);
			InitializeBoard();
		}

		private void InitializeBoard()
		{
			GridPanel.Controls.Clear();
			_brushes.Clear();
			_destinations.Clear();
			_rotatings.Clear();
			for (int y = 0; y < _y + 2; y++)
			{
				for (int x = 0; x < _x + 2; x++)
				{
					if (!IsZoneAvailable(x, y)) continue;
					Panel panel = new Panel();
					Point location = new Point(x, y);
					panel.BorderStyle = BorderStyle.FixedSingle;
					panel.BackgroundImageLayout = ImageLayout.Zoom;
					_brushes.Add(location, Brush.Unset);
					if (IsParkZone(x, _x) || IsParkZone(y, _y))
					{
						panel.AccessibleName = "Park";
						panel.Click += PaintPark;
						panel.BackColor = Color.Black;
						panel.BackgroundImage = Destination.Unset.GetImage();
						_destinations.Add(location, Destination.Unset);
					}
					else
					{
						panel.AccessibleName = "Road";
						panel.Click += PaintRoad;
						panel.BackColor = SystemColors.Control;
						_rotatings.Add(location, Rotating.Unset);
					}

					panel.Tag = location;
					panel.Location = new System.Drawing.Point(x * TileSize, y * TileSize);
					panel.Size = new Size(TileSize, TileSize);
					GridPanel.Controls.Add(panel);
				}
			}
		}

		private void PaintPark(object sender, EventArgs e)
		{
			Panel panel = (Panel)sender;
			Point location = GetPoint(panel);

			if (Destination != Destination.Unset)
			{
				panel.BackColor = Brush == Brush.Unset ? Color.Black : Brush.GetColor();
			}
			else
			{
				panel.BackColor = SystemColors.Control;
			}

			_brushes[location] = Brush;
			_destinations[location] = Destination;
			panel.BackgroundImage = Destination.GetImage();
		}

		private void PaintRoad(object sender, EventArgs e)
		{
			Panel panel = (Panel)sender;
			Point location = GetPoint(panel);

			panel.BackColor = Brush.GetColor();
			_brushes[location] = Brush;

			Image image = Rotating.GetImage();
			panel.BackgroundImage = image;

			_rotatings[location] = Rotating;
		}

		private bool IsParkZone(int value, int max)
		{
			return value == 0 || value == max + 1;
		}

		private bool IsZoneAvailable(int x, int y)
		{
			if (x == 0 && y == 0)
				return false;
			if (x == 0 && y == _y + 1)
				return false;
			if (x == _x + 1 && y == 0)
				return false;
			if (x == _x + 1 && y == _y + 1)
				return false;

			return true;
		}

		private void ExportButton_Click(object sender, EventArgs e)
		{
			string output = $"{Convert.ToInt32(MovesInput.Value)}\n#\n";
			List<Point> parks = new List<Point>();
			List<Point> roads = new List<Point>();
			foreach (Control control in GridPanel.Controls)
			{
				bool isPark = control.AccessibleName == "Park";
				Point location = GetPoint(control);
				if (isPark)
				{
					if (_destinations[location] != Destination.Unset)
						parks.Add(location);
				}
				else
				{
					roads.Add(location);
				}
			}

			foreach (Point point in parks)
			{
				output += $"{InvertPoint(point).ToString()}:{(int)_brushes[point]}, ";
			}

			output = output.Substring(0, output.Length - 2);
			output += "\n|\n";

			foreach (Point point in roads)
			{
				output += $"{InvertPoint(point).ToString()}:{(int)_brushes[point]}, ";
			}

			output = output.Substring(0, output.Length - 2);
			bool added = false;
			foreach (Point point in roads)
			{
				if (_rotatings[point] != Rotating.Unset)
				{
					if (!added)
					{
						output += "\n|\n";
						added = true;
					}

					int to_right = _rotatings[point].IsToRight() ? 1 : 0;
					int to_s_or_n = _rotatings[point].IsToSorToN() ? 1 : 0;
					int rotation = _rotatings[point].ToInt();
					output += $"{InvertPoint(point).ToString()}:{to_right}:{rotation}:{to_s_or_n}, ";
				}
			}

			output = output.Substring(0, output.Length - 2);

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.DefaultExt = "txt";
			saveFileDialog.Filter = "Level Info|*.txt";
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, output);
			}
		}

		private void NoneButton_Click(object sender, EventArgs e)
		{
			Brush = Brush.Unset;
		}

		private void RedButton_Click(object sender, EventArgs e)
		{
			Brush = Brush.Red;
		}

		private void GreenButton_Click(object sender, EventArgs e)
		{
			Brush = Brush.Green;
		}

		private void BlueButton_Click(object sender, EventArgs e)
		{
			Brush = Brush.Blue;
		}

		private void YellowButton_Click(object sender, EventArgs e)
		{
			Brush = Brush.Yellow;
		}

		private void NoneParkButton_Click(object sender, EventArgs e)
		{
			Destination = Destination.Unset;
		}

		private void ArrowButton_Click(object sender, EventArgs e)
		{
			Destination = Destination.Arrow;
		}

		private void ParkButton_Click(object sender, EventArgs e)
		{
			Destination = Destination.Park;
		}

		private void NoneRotatingButton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.Unset;
		}

		private Point GetPointS(Control control)
		{
			return new Point(Location.X / TileSize, Location.Y / TileSize);
		}

		private Point GetPoint(Control control)
		{
			return (Point)control.Tag;
		}

		private Point InvertPoint(Point point)
		{
			return new Point(-point.X + _x, -point.Y + _y);
		}

		private void TurnButton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.TurningLeftSW;
		}

		private void TurnRightButton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.TurningRightSE;
		}

		private void RotateLeftESbutton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.TurningLeftES;
		}

		private void RotateRightWSbutton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.TurningRightWS;
		}

		private void RotateLeftNEbutton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.TurningLeftNE;
		}

		private void RotateRightNWbutton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.TurningRightNW;
		}

		private void RotateLeftWNbutton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.TurningLeftWN;
		}

		private void RotateRightENbutton_Click(object sender, EventArgs e)
		{
			Rotating = Rotating.TurningRightEN;
		}
	}
}