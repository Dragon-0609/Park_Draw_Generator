namespace ParkDrawGenerator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GridPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.RotateRightENbutton = new System.Windows.Forms.Button();
			this.RotateRightNWbutton = new System.Windows.Forms.Button();
			this.RotateRightWSbutton = new System.Windows.Forms.Button();
			this.RotateLeftWNbutton = new System.Windows.Forms.Button();
			this.RotateLeftNEbutton = new System.Windows.Forms.Button();
			this.RotateLeftESbutton = new System.Windows.Forms.Button();
			this.MovesInput = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.ExportButton = new System.Windows.Forms.Button();
			this.NoneRotatingButton = new System.Windows.Forms.Button();
			this.NoneParkButton = new System.Windows.Forms.Button();
			this.TurnRightButton = new System.Windows.Forms.Button();
			this.NoneButton = new System.Windows.Forms.Button();
			this.TurnLeftButton = new System.Windows.Forms.Button();
			this.ParkButton = new System.Windows.Forms.Button();
			this.ArrowButton = new System.Windows.Forms.Button();
			this.YellowButton = new System.Windows.Forms.Button();
			this.BlueButton = new System.Windows.Forms.Button();
			this.GreenButton = new System.Windows.Forms.Button();
			this.RedButton = new System.Windows.Forms.Button();
			this.YInput = new System.Windows.Forms.NumericUpDown();
			this.XInput = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MovesInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.XInput)).BeginInit();
			this.SuspendLayout();
			// 
			// GridPanel
			// 
			this.GridPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.GridPanel.Location = new System.Drawing.Point(0, 0);
			this.GridPanel.Margin = new System.Windows.Forms.Padding(4);
			this.GridPanel.Name = "GridPanel";
			this.GridPanel.Size = new System.Drawing.Size(509, 683);
			this.GridPanel.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.RotateRightENbutton);
			this.panel2.Controls.Add(this.RotateRightNWbutton);
			this.panel2.Controls.Add(this.RotateRightWSbutton);
			this.panel2.Controls.Add(this.RotateLeftWNbutton);
			this.panel2.Controls.Add(this.RotateLeftNEbutton);
			this.panel2.Controls.Add(this.RotateLeftESbutton);
			this.panel2.Controls.Add(this.MovesInput);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.ExportButton);
			this.panel2.Controls.Add(this.NoneRotatingButton);
			this.panel2.Controls.Add(this.NoneParkButton);
			this.panel2.Controls.Add(this.TurnRightButton);
			this.panel2.Controls.Add(this.NoneButton);
			this.panel2.Controls.Add(this.TurnLeftButton);
			this.panel2.Controls.Add(this.ParkButton);
			this.panel2.Controls.Add(this.ArrowButton);
			this.panel2.Controls.Add(this.YellowButton);
			this.panel2.Controls.Add(this.BlueButton);
			this.panel2.Controls.Add(this.GreenButton);
			this.panel2.Controls.Add(this.RedButton);
			this.panel2.Controls.Add(this.YInput);
			this.panel2.Controls.Add(this.XInput);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(508, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(211, 683);
			this.panel2.TabIndex = 1;
			// 
			// RotateRightESbutton
			// 
			this.RotateRightENbutton.BackColor = System.Drawing.Color.Black;
			this.RotateRightENbutton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Turn_arrow_right_en;
			this.RotateRightENbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RotateRightENbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RotateRightENbutton.ForeColor = System.Drawing.Color.Black;
			this.RotateRightENbutton.Location = new System.Drawing.Point(121, 520);
			this.RotateRightENbutton.Margin = new System.Windows.Forms.Padding(4);
			this.RotateRightENbutton.Name = "RotateRightENbutton";
			this.RotateRightENbutton.Size = new System.Drawing.Size(45, 44);
			this.RotateRightENbutton.TabIndex = 22;
			this.RotateRightENbutton.UseVisualStyleBackColor = false;
			this.RotateRightENbutton.Click += new System.EventHandler(this.RotateRightENbutton_Click);
			// 
			// RotateRightNWbutton
			// 
			this.RotateRightNWbutton.BackColor = System.Drawing.Color.Black;
			this.RotateRightNWbutton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Turn_arrow_right_nw;
			this.RotateRightNWbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RotateRightNWbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RotateRightNWbutton.ForeColor = System.Drawing.Color.Black;
			this.RotateRightNWbutton.Location = new System.Drawing.Point(121, 468);
			this.RotateRightNWbutton.Margin = new System.Windows.Forms.Padding(4);
			this.RotateRightNWbutton.Name = "RotateRightNWbutton";
			this.RotateRightNWbutton.Size = new System.Drawing.Size(45, 44);
			this.RotateRightNWbutton.TabIndex = 21;
			this.RotateRightNWbutton.UseVisualStyleBackColor = false;
			this.RotateRightNWbutton.Click += new System.EventHandler(this.RotateRightNWbutton_Click);
			// 
			// RotateRightWSbutton
			// 
			this.RotateRightWSbutton.BackColor = System.Drawing.Color.Black;
			this.RotateRightWSbutton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Turn_arrow_right_se;
			this.RotateRightWSbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RotateRightWSbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RotateRightWSbutton.ForeColor = System.Drawing.Color.Black;
			this.RotateRightWSbutton.Location = new System.Drawing.Point(121, 416);
			this.RotateRightWSbutton.Margin = new System.Windows.Forms.Padding(4);
			this.RotateRightWSbutton.Name = "RotateRightWSbutton";
			this.RotateRightWSbutton.Size = new System.Drawing.Size(45, 44);
			this.RotateRightWSbutton.TabIndex = 20;
			this.RotateRightWSbutton.UseVisualStyleBackColor = false;
			this.RotateRightWSbutton.Click += new System.EventHandler(this.RotateRightWSbutton_Click);
			// 
			// RotateLeftWNbutton
			// 
			this.RotateLeftWNbutton.BackColor = System.Drawing.Color.Black;
			this.RotateLeftWNbutton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Turn_arrow_left_wn;
			this.RotateLeftWNbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RotateLeftWNbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RotateLeftWNbutton.Location = new System.Drawing.Point(68, 520);
			this.RotateLeftWNbutton.Margin = new System.Windows.Forms.Padding(4);
			this.RotateLeftWNbutton.Name = "RotateLeftWNbutton";
			this.RotateLeftWNbutton.Size = new System.Drawing.Size(45, 44);
			this.RotateLeftWNbutton.TabIndex = 19;
			this.RotateLeftWNbutton.UseVisualStyleBackColor = false;
			this.RotateLeftWNbutton.Click += new System.EventHandler(this.RotateLeftWNbutton_Click);
			// 
			// RotateLeftNEbutton
			// 
			this.RotateLeftNEbutton.BackColor = System.Drawing.Color.Black;
			this.RotateLeftNEbutton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Turn_arrow_left_ne;
			this.RotateLeftNEbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RotateLeftNEbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RotateLeftNEbutton.Location = new System.Drawing.Point(68, 468);
			this.RotateLeftNEbutton.Margin = new System.Windows.Forms.Padding(4);
			this.RotateLeftNEbutton.Name = "RotateLeftNEbutton";
			this.RotateLeftNEbutton.Size = new System.Drawing.Size(45, 44);
			this.RotateLeftNEbutton.TabIndex = 18;
			this.RotateLeftNEbutton.UseVisualStyleBackColor = false;
			this.RotateLeftNEbutton.Click += new System.EventHandler(this.RotateLeftNEbutton_Click);
			// 
			// RotateLeftESbutton
			// 
			this.RotateLeftESbutton.BackColor = System.Drawing.Color.Black;
			this.RotateLeftESbutton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Turn_arrow_left_es;
			this.RotateLeftESbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RotateLeftESbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RotateLeftESbutton.Location = new System.Drawing.Point(68, 416);
			this.RotateLeftESbutton.Margin = new System.Windows.Forms.Padding(4);
			this.RotateLeftESbutton.Name = "RotateLeftESbutton";
			this.RotateLeftESbutton.Size = new System.Drawing.Size(45, 44);
			this.RotateLeftESbutton.TabIndex = 17;
			this.RotateLeftESbutton.UseVisualStyleBackColor = false;
			this.RotateLeftESbutton.Click += new System.EventHandler(this.RotateLeftESbutton_Click);
			// 
			// MovesInput
			// 
			this.MovesInput.Location = new System.Drawing.Point(15, 130);
			this.MovesInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			this.MovesInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.MovesInput.Name = "MovesInput";
			this.MovesInput.Size = new System.Drawing.Size(63, 24);
			this.MovesInput.TabIndex = 16;
			this.MovesInput.Value = new decimal(new int[] { 2, 0, 0, 0 });
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 31);
			this.label2.TabIndex = 15;
			this.label2.Text = "Moves";
			// 
			// ExportButton
			// 
			this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.ExportButton.Location = new System.Drawing.Point(44, 629);
			this.ExportButton.Margin = new System.Windows.Forms.Padding(4);
			this.ExportButton.Name = "ExportButton";
			this.ExportButton.Size = new System.Drawing.Size(137, 41);
			this.ExportButton.TabIndex = 14;
			this.ExportButton.Text = "Export";
			this.ExportButton.UseVisualStyleBackColor = true;
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			// 
			// NoneRotatingButton
			// 
			this.NoneRotatingButton.BackColor = System.Drawing.Color.Black;
			this.NoneRotatingButton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.kwadrat2;
			this.NoneRotatingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NoneRotatingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NoneRotatingButton.Location = new System.Drawing.Point(15, 364);
			this.NoneRotatingButton.Margin = new System.Windows.Forms.Padding(4);
			this.NoneRotatingButton.Name = "NoneRotatingButton";
			this.NoneRotatingButton.Size = new System.Drawing.Size(45, 44);
			this.NoneRotatingButton.TabIndex = 13;
			this.NoneRotatingButton.UseVisualStyleBackColor = false;
			this.NoneRotatingButton.Click += new System.EventHandler(this.NoneRotatingButton_Click);
			// 
			// NoneParkButton
			// 
			this.NoneParkButton.BackColor = System.Drawing.Color.Black;
			this.NoneParkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NoneParkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NoneParkButton.Location = new System.Drawing.Point(15, 299);
			this.NoneParkButton.Margin = new System.Windows.Forms.Padding(4);
			this.NoneParkButton.Name = "NoneParkButton";
			this.NoneParkButton.Size = new System.Drawing.Size(45, 44);
			this.NoneParkButton.TabIndex = 12;
			this.NoneParkButton.UseVisualStyleBackColor = false;
			this.NoneParkButton.Click += new System.EventHandler(this.NoneParkButton_Click);
			// 
			// TurnRightButton
			// 
			this.TurnRightButton.BackColor = System.Drawing.Color.Black;
			this.TurnRightButton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Turn_arrow_right;
			this.TurnRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.TurnRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TurnRightButton.ForeColor = System.Drawing.Color.Black;
			this.TurnRightButton.Location = new System.Drawing.Point(122, 364);
			this.TurnRightButton.Margin = new System.Windows.Forms.Padding(4);
			this.TurnRightButton.Name = "TurnRightButton";
			this.TurnRightButton.Size = new System.Drawing.Size(45, 44);
			this.TurnRightButton.TabIndex = 11;
			this.TurnRightButton.UseVisualStyleBackColor = false;
			this.TurnRightButton.Click += new System.EventHandler(this.TurnRightButton_Click);
			// 
			// NoneButton
			// 
			this.NoneButton.BackColor = System.Drawing.Color.Black;
			this.NoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NoneButton.Location = new System.Drawing.Point(15, 182);
			this.NoneButton.Margin = new System.Windows.Forms.Padding(4);
			this.NoneButton.Name = "NoneButton";
			this.NoneButton.Size = new System.Drawing.Size(45, 44);
			this.NoneButton.TabIndex = 10;
			this.NoneButton.UseVisualStyleBackColor = false;
			this.NoneButton.Click += new System.EventHandler(this.NoneButton_Click);
			// 
			// TurnLeftButton
			// 
			this.TurnLeftButton.BackColor = System.Drawing.Color.Black;
			this.TurnLeftButton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Turn_arrow;
			this.TurnLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.TurnLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TurnLeftButton.Location = new System.Drawing.Point(69, 364);
			this.TurnLeftButton.Margin = new System.Windows.Forms.Padding(4);
			this.TurnLeftButton.Name = "TurnLeftButton";
			this.TurnLeftButton.Size = new System.Drawing.Size(45, 44);
			this.TurnLeftButton.TabIndex = 9;
			this.TurnLeftButton.UseVisualStyleBackColor = false;
			this.TurnLeftButton.Click += new System.EventHandler(this.TurnButton_Click);
			// 
			// ParkButton
			// 
			this.ParkButton.BackColor = System.Drawing.Color.Black;
			this.ParkButton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Parking__2_;
			this.ParkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ParkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ParkButton.Location = new System.Drawing.Point(122, 299);
			this.ParkButton.Margin = new System.Windows.Forms.Padding(4);
			this.ParkButton.Name = "ParkButton";
			this.ParkButton.Size = new System.Drawing.Size(45, 44);
			this.ParkButton.TabIndex = 8;
			this.ParkButton.UseVisualStyleBackColor = false;
			this.ParkButton.Click += new System.EventHandler(this.ParkButton_Click);
			// 
			// ArrowButton
			// 
			this.ArrowButton.BackColor = System.Drawing.Color.Black;
			this.ArrowButton.BackgroundImage = global::ParkDrawGenerator.Properties.Resources.Arrow__2_;
			this.ArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ArrowButton.Location = new System.Drawing.Point(69, 299);
			this.ArrowButton.Margin = new System.Windows.Forms.Padding(4);
			this.ArrowButton.Name = "ArrowButton";
			this.ArrowButton.Size = new System.Drawing.Size(45, 44);
			this.ArrowButton.TabIndex = 7;
			this.ArrowButton.UseVisualStyleBackColor = false;
			this.ArrowButton.Click += new System.EventHandler(this.ArrowButton_Click);
			// 
			// YellowButton
			// 
			this.YellowButton.BackColor = System.Drawing.Color.Yellow;
			this.YellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.YellowButton.Location = new System.Drawing.Point(69, 235);
			this.YellowButton.Margin = new System.Windows.Forms.Padding(4);
			this.YellowButton.Name = "YellowButton";
			this.YellowButton.Size = new System.Drawing.Size(45, 44);
			this.YellowButton.TabIndex = 6;
			this.YellowButton.UseVisualStyleBackColor = false;
			this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
			// 
			// BlueButton
			// 
			this.BlueButton.BackColor = System.Drawing.Color.Blue;
			this.BlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BlueButton.Location = new System.Drawing.Point(15, 235);
			this.BlueButton.Margin = new System.Windows.Forms.Padding(4);
			this.BlueButton.Name = "BlueButton";
			this.BlueButton.Size = new System.Drawing.Size(45, 44);
			this.BlueButton.TabIndex = 5;
			this.BlueButton.UseVisualStyleBackColor = false;
			this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
			// 
			// GreenButton
			// 
			this.GreenButton.BackColor = System.Drawing.Color.Green;
			this.GreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GreenButton.Location = new System.Drawing.Point(122, 182);
			this.GreenButton.Margin = new System.Windows.Forms.Padding(4);
			this.GreenButton.Name = "GreenButton";
			this.GreenButton.Size = new System.Drawing.Size(45, 44);
			this.GreenButton.TabIndex = 4;
			this.GreenButton.UseVisualStyleBackColor = false;
			this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
			// 
			// RedButton
			// 
			this.RedButton.BackColor = System.Drawing.Color.Red;
			this.RedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RedButton.Location = new System.Drawing.Point(69, 182);
			this.RedButton.Margin = new System.Windows.Forms.Padding(4);
			this.RedButton.Name = "RedButton";
			this.RedButton.Size = new System.Drawing.Size(45, 44);
			this.RedButton.TabIndex = 3;
			this.RedButton.UseVisualStyleBackColor = false;
			this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
			// 
			// YInput
			// 
			this.YInput.Location = new System.Drawing.Point(99, 58);
			this.YInput.Margin = new System.Windows.Forms.Padding(4);
			this.YInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.YInput.Name = "YInput";
			this.YInput.Size = new System.Drawing.Size(67, 24);
			this.YInput.TabIndex = 2;
			this.YInput.Value = new decimal(new int[] { 2, 0, 0, 0 });
			this.YInput.ValueChanged += new System.EventHandler(this.YInput_ValueChanged);
			// 
			// XInput
			// 
			this.XInput.Location = new System.Drawing.Point(15, 58);
			this.XInput.Margin = new System.Windows.Forms.Padding(4);
			this.XInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.XInput.Name = "XInput";
			this.XInput.Size = new System.Drawing.Size(63, 24);
			this.XInput.TabIndex = 1;
			this.XInput.Value = new decimal(new int[] { 2, 0, 0, 0 });
			this.XInput.ValueChanged += new System.EventHandler(this.XInput_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Level Size";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 683);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.GridPanel);
			this.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MovesInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.XInput)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button RotateRightENbutton;

		private System.Windows.Forms.Button RotateRightNWbutton;

		private System.Windows.Forms.Button RotateRightWSbutton;

		private System.Windows.Forms.Button RotateLeftWNbutton;

		private System.Windows.Forms.Button RotateLeftNEbutton;

		private System.Windows.Forms.Button RotateLeftESbutton;

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown MovesInput;

		private System.Windows.Forms.Button ExportButton;

		private System.Windows.Forms.Button NoneRotatingButton;

		private System.Windows.Forms.Button NoneParkButton;

		private System.Windows.Forms.Button TurnRightButton;

		private System.Windows.Forms.Button NoneButton;

		private System.Windows.Forms.Button TurnLeftButton;

		private System.Windows.Forms.Button ParkButton;

		private System.Windows.Forms.Button ArrowButton;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown XInput;
		private System.Windows.Forms.NumericUpDown YInput;
		private System.Windows.Forms.Button RedButton;
		private System.Windows.Forms.Button GreenButton;
		private System.Windows.Forms.Button BlueButton;
		private System.Windows.Forms.Button YellowButton;

		private System.Windows.Forms.Panel panel2;

		private System.Windows.Forms.Panel GridPanel;

		#endregion
	}
}