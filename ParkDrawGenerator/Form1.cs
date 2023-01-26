using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Point = ParkDrawGenerator.Point;

namespace ParkDrawGenerator
{
	public partial class Form1 : Form
	{
		private int _x = 2, _y = 2;
		private const int TileSize = 40;
		private Brush _brush = Brush.Unset;
		private Destination _destination = Destination.Unset;
		private Rotating _rotating = Rotating.Unset;
		private Barrier _barrier = Barrier.Unset;
		private Dictionary<Point, Brush> _brushes = new();
		private Dictionary<Point, Destination> _destinations = new();
		private Dictionary<Point, Rotating> _rotatings = new();
		private Dictionary<Point, Barrier> _barriers = new();

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
			_barriers.Clear();
			GC.Collect();
			GC.WaitForPendingFinalizers();
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
						_barriers.Add(location, Barrier.Unset);
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

			panel.BackColor = _brush == Brush.Unset ? Color.Black : _brush.GetColor();

			_brushes[location] = _brush;
			_destinations[location] = _destination;
			_barriers[location] = _barrier;
			if (panel.BackgroundImage != null)
				panel.BackgroundImage.Dispose();
			panel.BackgroundImage = new[] { _destination.GetImage(), _barrier.GetImage() }.CombineBitmap();

		}

		private void PaintRoad(object sender, EventArgs e)
		{
			Panel panel = (Panel)sender;
			Point location = GetPoint(panel);

			panel.BackColor = _brush.GetColor();
			_brushes[location] = _brush;

			Image image = _rotating.GetImage();
			panel.BackgroundImage = image;

			_rotatings[location] = _rotating;
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
			GetParksAndRoads(parks, roads);

			output += ExportParks(parks);
			output += ExportRoads(roads);
			output += ExportRotatings(roads, parks);
			output += ExportBarriers(parks);

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.DefaultExt = "txt";
			saveFileDialog.Filter = "Level Info|*.txt";
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, output);
			}
		}

		private void GetParksAndRoads(List<Point> parks, List<Point> roads)
		{
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
		}

		private string ExportParks(List<Point> parks)
		{
			string output = "";
			foreach (Point point in parks)
			{
				string btn = "";
				if (_destinations[point] == Destination.Button)
				{
					btn = ":1";
				}
				output += $"{InvertPoint(point).ToString()}:{(int)_brushes[point]}{btn}, ";
			}

			output = Cut(output);
			output += "\n|\n";
			return output;
		}

		private string ExportRoads(List<Point> roads)
		{
			string output = "";
			foreach (Point point in roads)
			{
				string s = $"{InvertPoint(point).ToString()}:{(int)_brushes[point]}, ";
				output += s;
			}

			output = Cut(output);
			return output;
		}

		private string ExportRotatings(List<Point> roads, List<Point> parks)
		{
			string output = "";
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

					int toRight = _rotatings[point].IsToRight() ? 1 : 0;
					int toSOrN = _rotatings[point].IsToSorToN() ? 1 : 0;
					int rotation = _rotatings[point].ToInt();
					output += $"{InvertPoint(point).ToString()}:{toRight}:{rotation}:{toSOrN}, ";
				}
			}

			if (added)
			{
				output = Cut(output);
			}
			else{
				output += "\n|\n";
			}
			return output;
		}

		private string ExportBarriers(List<Point> parks)
		{
			string output = "";
			bool has = false;
			if (_barriers.Any(pair => pair.Value == Barrier.Barrier))
			{
				output += "\n|\n";
				has = true;
			}
			foreach (Point point in parks)
			{
				if (_barriers[point] == Barrier.Barrier)
				{
					output += $"{InvertPoint(point).ToString()}, ";
				}
			}

			if (has)
			{
				output = Cut(output);
			}
			return output;
		}

		private static string Cut(string output)
		{
			output = output.Substring(0, output.Length - 2);
			return output;
		}

		private void NoneButton_Click(object sender, EventArgs e)
		{
			_brush = Brush.Unset;
		}

		private void RedButton_Click(object sender, EventArgs e)
		{
			_brush = Brush.Red;
		}

		private void GreenButton_Click(object sender, EventArgs e)
		{
			_brush = Brush.Green;
		}

		private void BlueButton_Click(object sender, EventArgs e)
		{
			_brush = Brush.Blue;
		}

		private void YellowButton_Click(object sender, EventArgs e)
		{
			_brush = Brush.Yellow;
		}

		private void NoneParkButton_Click(object sender, EventArgs e)
		{
			_destination = Destination.Unset;
		}

		private void ArrowButton_Click(object sender, EventArgs e)
		{
			_destination = Destination.Arrow;
		}

		private void ParkButton_Click(object sender, EventArgs e)
		{
			_destination = Destination.Park;
		}

		private void NoneRotatingButton_Click(object sender, EventArgs e)
		{
			_rotating = Rotating.Unset;
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
			_rotating = Rotating.TurningLeftSW;
		}

		private void TurnRightButton_Click(object sender, EventArgs e)
		{
			_rotating = Rotating.TurningRightSE;
		}

		private void RotateLeftESbutton_Click(object sender, EventArgs e)
		{
			_rotating = Rotating.TurningLeftES;
		}

		private void RotateRightWSbutton_Click(object sender, EventArgs e)
		{
			_rotating = Rotating.TurningRightWS;
		}

		private void RotateLeftNEbutton_Click(object sender, EventArgs e)
		{
			_rotating = Rotating.TurningLeftNE;
		}

		private void RotateRightNWbutton_Click(object sender, EventArgs e)
		{
			_rotating = Rotating.TurningRightNW;
		}

		private void RotateLeftWNbutton_Click(object sender, EventArgs e)
		{
			_rotating = Rotating.TurningLeftWN;
		}

		private void RotateRightENbutton_Click(object sender, EventArgs e)
		{
			_rotating = Rotating.TurningRightEN;
		}

		private void ButtonButton_Click(object sender, EventArgs e)
		{
			_destination = Destination.Button;
		}

		private void NoneBarrierButton_Click(object sender, EventArgs e)
		{
			_barrier = Barrier.Unset;
		}

		private void BarrierButton_Click(object sender, EventArgs e)
		{
			_barrier = Barrier.Barrier;
		}
	}
}