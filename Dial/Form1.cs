// Contributors:  Justin Hutchison (yibbidy@gmail.com)

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Dial
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1() {
			this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
			this.UpdateStyles();
			
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Min:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Max:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "0";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "1";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(96, 328);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "&Ranged";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(64, 352);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 104);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Text";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(24, 72);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "&None";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(24, 48);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "&End Points";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(24, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "At &Ticks";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(104, 120);
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "0.2";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(104, 88);
			this.textBox4.Name = "textBox4";
			this.textBox4.TabIndex = 2;
			this.textBox4.Text = "0.5";
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Default Range:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Default Value:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(104, 504);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.TabIndex = 10;
			this.textBox5.TabStop = false;
			this.textBox5.Text = "0";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(104, 472);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.TabIndex = 9;
			this.textBox6.TabStop = false;
			this.textBox6.Text = "0.5";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(56, 504);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Range:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(56, 472);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Value:";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(104, 216);
			this.textBox7.Name = "textBox7";
			this.textBox7.TabIndex = 6;
			this.textBox7.Text = "100";
			this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(40, 216);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "Radius:";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(104, 184);
			this.textBox8.Name = "textBox8";
			this.textBox8.TabIndex = 5;
			this.textBox8.Text = "2";
			this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(104, 152);
			this.textBox9.Name = "textBox9";
			this.textBox9.TabIndex = 4;
			this.textBox9.Text = "1";
			this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 184);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 23);
			this.label8.TabIndex = 17;
			this.label8.Text = "SubTick Count:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(32, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Tick Count:";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(104, 272);
			this.textBox10.Name = "textBox10";
			this.textBox10.TabIndex = 8;
			this.textBox10.Text = "90";
			this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(32, 272);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 19;
			this.label10.Text = "Split Angle:";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(104, 240);
			this.hScrollBar1.Maximum = 500;
			this.hScrollBar1.Minimum = 8;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(100, 17);
			this.hScrollBar1.TabIndex = 7;
			this.hScrollBar1.Value = 100;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(104, 296);
			this.hScrollBar2.Maximum = 359;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(100, 17);
			this.hScrollBar2.TabIndex = 9;
			this.hScrollBar2.Value = 90;
			this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Controls.Add(this.hScrollBar2);
			this.groupBox2.Controls.Add(this.textBox10);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBox8);
			this.groupBox2.Controls.Add(this.textBox9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.hScrollBar1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox2.Location = new System.Drawing.Point(466, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(216, 552);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dial Properties";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(682, 552);
			this.Controls.Add(this.groupBox2);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "Dial Control";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}


		public delegate void ValueChangedHandler();

		public event ValueChangedHandler ValueChanged;
		double Value {
			get {
				return val;
			}
			set {
				value = Math.Min(Math.Max(value, min), max);

				bool valueChanged = (value!=val);
				
				val = value;
				valueAngle = (float)((val-min)/(max-min)*(360.0-2.0*baseAngle) + baseAngle);
				
				if( !valueChanged ) return;

				if( ValueChanged != null ) ValueChanged();
				Invalidate();
			}
		}
		double val = 0.5;
		public double Range {
			get {
				if( !ranged ) return 0.0;
				return range-val;
			}
			set {
				value = Math.Min(Math.Max(value+val, min), max);

				bool valueChanged = (value!=range);
				
				range = value;
				rangeAngle = (float)((range-min)/(max-min)*(360.0-2.0*baseAngle) + baseAngle);

				if( !valueChanged ) return;

				if( ValueChanged != null ) ValueChanged();

				Invalidate();
			}
		}
		double range = 0.2;
		public bool Ranged {
			get {
				return ranged;
			}
			set {
				ranged = value;
				if( ranged ) {
					rangeAngle = valueAngle;
					if( ValueChanged != null ) ValueChanged();
				}
				Invalidate();
			}
		}
		bool ranged = false;
		
		public double Min {
			get {
				return min;
			}
			set {
				if( value == max ) return;

				if( value > max ) {
					min = max;
					max = value;
				} else {
					min = value;
				}
				if( val<min ) Value = min;
				else if( val>max ) Value = max;

				if( defaultValue < min ) defaultValue = min;
				else if( defaultValue > max ) defaultValue = max;

				if( range<min ) Range = min;
				else if( range>max ) Range = max;

				if( defaultRange < min ) defaultRange = min;
				else if( defaultRange > max ) defaultRange = max;

				Invalidate();
			}
		}
		double min = 0.0;
		public double Max {
			get {
				return max;
			}
			set {
				if( value == min ) return;

				if( value < min ) {
					max = min;
					min = value;
				} else {
					max = value;
				}
				
				if( val<min ) Value = min;
				else if( val>max ) Value = max;

				if( defaultValue < min ) defaultValue = min;
				else if( defaultValue > max ) defaultValue = max;

				if( range<min ) Range = min;
				else if( range>max ) Range = max;

				if( defaultRange < min ) defaultRange = min;
				else if( defaultRange > max ) defaultRange = max;
				
				Invalidate();
			}
		}
		double max = 1.0;
		float SplitAngle {
			get {
				return baseAngle*2.0f;
			}
			set {
				if( value<0.0f || value>=360.0f ) return;

				if( 0.0f==baseAngle && value>0.0f ) ++tickCount;
				else if( baseAngle>=0.0f && 0.0f==value ) --tickCount;

				baseAngle = value*0.5f;
				valueAngle = (float)((val-min)/(max-min)*(360.0-2.0*baseAngle) + baseAngle);
				rangeAngle = (float)((range-min)/(max-min)*(360.0-2.0*baseAngle) + baseAngle);
				Invalidate();
			}
		}
		float baseAngle = 45.0f; // degrees
		public double DefaultValue {
			get {
				return defaultValue;
			}
			set {
				value = Math.Min(Math.Max(value, min), max);

				defaultValue = value;
			}
		}

		double defaultValue = 0.5;
		public double DefaultRange {
			get {
				return defaultRange-defaultValue;
			}
			set {
				value = Math.Min(Math.Max(value+defaultValue, min), max);
				defaultRange = value;
			}
		}

		double defaultRange = 0.7;
		public enum TickLabels {
			None,
			EndPoints,
			Ticks
		}

		public TickLabels Labels {
			get {
				return labels;
			}
			set {
				labels = value;
				Invalidate();
			}
		}

		TickLabels labels = TickLabels.EndPoints;
		public float Radius {
			get {
				return radius;
			}
			set {
				if( value < 8.0f ) return;

				radius = value;
				Invalidate();
			}
		}
		float radius = 100.0f;
			
		int centerX = 250;
		int centerY = 250;

		public int TickCount {
			get {
				return tickCount;
			}
			set {
				value = Math.Max(0, value-2);
				tickCount = value;
				Invalidate();
			}
		}
		int tickCount = 3;
		public int TacksPerTick {
			get {
				return tacksPerTick;
			}
			set {
				value = Math.Max(0, value);
				tacksPerTick = value;
				Invalidate();
			}
		}
		int tacksPerTick = 2;

		enum Drags {
			Left,
			Right,
			Center,
			None
		};
		Drags drag = Drags.None;

		private float ValueAngle {
			set {
				valueAngle = value;
				val = ((valueAngle-baseAngle) / (360.0-2.0*baseAngle)) * (max-min) + min;
			}
		}
				
		float valueAngle = 180.0f;
		private float RangeAngle {
			set {
				rangeAngle = value;
				range = ((rangeAngle-baseAngle) / (360.0-2.0*baseAngle)) * (max-min) + min;
			}
		}
				
		float rangeAngle = 270.0f;
		float holdAngle = 0.0f;
		#region Controls 
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			DrawDial(e.Graphics);
			DrawTicks(e.Graphics);
			DrawValue(e.Graphics);
			if( ranged ) DrawRange(e.Graphics);
			DrawAdornments(e.Graphics);

		}

		private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) {
			if( 'r' == e.KeyChar ) {
				radius = 50.0f;
				Invalidate();
			}
		}

		private void label6_Click(object sender, System.EventArgs e) {
		
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			ValueChanged += new ValueChangedHandler(Form1_ValueChanged);
		
			centerX = (Width-groupBox2.Width)/2;
			centerY = Height/2;
		}

		private void textBox7_TextChanged(object sender, System.EventArgs e) {
			try {
				Radius = float.Parse(textBox7.Text);
			} catch( Exception ) {
			}
		}

		private void textBox3_TextChanged(object sender, System.EventArgs e) {
			try {
				DefaultRange = double.Parse(textBox3.Text);
			} catch( Exception ) {
			}
		}

		private void textBox4_TextChanged(object sender, System.EventArgs e) {
			try {
				DefaultValue = double.Parse(textBox4.Text);
			} catch( Exception ) {
			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e) {
			try {
				Min = double.Parse(textBox1.Text);
			} catch( Exception ) {
			}
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e) {
			try {
				Max = double.Parse(textBox2.Text);
			} catch( Exception ) {
			}
		
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
			Ranged = checkBox1.Checked;
			Range = 1;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e) {
			if( radioButton1.Checked ) Labels = TickLabels.Ticks;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e) {
			if( radioButton2.Checked ) Labels = TickLabels.EndPoints;
		
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e) {
			if( radioButton3.Checked ) Labels = TickLabels.None;
		
		}

		private void textBox9_TextChanged(object sender, System.EventArgs e) {
			try {
				TickCount = int.Parse(textBox9.Text);
			} catch( Exception ) {
			}
		}

		private void textBox8_TextChanged(object sender, System.EventArgs e) {
			try {
				TacksPerTick = int.Parse(textBox8.Text);
			} catch( Exception ) {
			}
		}

		private void Form1_ValueChanged() {
			textBox6.Text = Math.Round(Value, 4).ToString();
			textBox5.Text = Math.Round(Range, 4).ToString();
		}

		#endregion
		bool mouseDown;
		private bool MouseOverReset(Point mouse) {
			double x = mouse.X-centerX;
			double y = mouse.Y-centerY;
			double mag = Math.Sqrt(x*x + y*y);
			if( mag<=SmallRadius() ) return true;
			return false;
		}

		private void ResetToDefault() {
			Value = defaultValue;
			Range = DefaultRange;
			Invalidate();
		}

		
		float valueAngleDiff = 0.0f;

		bool MouseInRange(Point mouse) {
			double x = mouse.X-centerX;
			double y = mouse.Y-centerY;
			double mag = Math.Sqrt(x*x + y*y);
			return mag<=radius;
			
		}
		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			Point mouse = new Point(e.X, e.Y);
			if( !MouseInRange(mouse) ) return;

			if( MouseOverReset(mouse) ) {
				ResetToDefault();
				return;
			}

			float angle = AngleAt(mouse);
			float barRadius = BarRadius();

			float minAngle = Math.Min(rangeAngle, valueAngle);
			float maxAngle = Math.Max(rangeAngle, valueAngle);
			
			if( Math.Abs(angle-valueAngle) <= barRadius ) {
				drag = Drags.Left;
			} else if( Math.Abs(angle-rangeAngle) <= barRadius ) {
				drag = Drags.Right;
			} else if( ranged && angle>=minAngle && angle<=maxAngle ) {
				drag = Drags.Center;
				holdAngle = angle;
				valueAngleDiff = angle - valueAngle;
			} else {
				drag = Drags.None;

				// do snapping
				if( (float)Math.Sqrt(Math.Pow(e.X-centerX, 2)+Math.Pow(e.Y-centerY, 2)) >= radius-15.0f ) angle = Snap(angle);		
					
				ValueAngle = angle;
				if( ValueChanged != null ) ValueChanged();

			}
			mouseDown = true;
			Form1_MouseMove(sender, e);
						
		}
		private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			Point mouse = new Point(e.X, e.Y);
			

			float angle = AngleAt(mouse);
			int nearestMultiple = -1;
			bool snap = (float)Math.Sqrt(Math.Pow(e.X-centerX, 2)+Math.Pow(e.Y-centerY, 2)) >= radius-15.0f;

			if( ((mouseDown && MouseOver.Center!=mouseOver) || MouseInRange(mouse)) && snap && Snap(angle, ref tick)!=angle ) {
				Invalidate();
			} else {
				if( tick != -1 ) {
					tick = -1;
					Invalidate();
				}
			}

			// highlight ui
			if( !mouseDown ) {
				if( !MouseInRange(mouse) ) {
					if( MouseOver.None == mouseOver ) Invalidate();
					mouseOver = MouseOver.None;
					return;
				}

				float barRadius = BarRadius();
				float minAngle = Math.Min(rangeAngle, valueAngle);
				float maxAngle = Math.Max(rangeAngle, valueAngle);
				if( MouseOverReset(mouse) ) {
					mouseOver = MouseOver.Reset;
				} else if( Math.Abs(angle-valueAngle) <= barRadius ) {
					mouseOver = MouseOver.Left;
				} else if( Math.Abs(angle-rangeAngle) <= barRadius ) {
					mouseOver = MouseOver.Right;
				} else if( ranged && angle>=minAngle && angle<=maxAngle ) {
					mouseOver = MouseOver.Center;
				} else {
					if( mouseOver != MouseOver.None ) Invalidate();
					mouseOver = MouseOver.None;
					return;
				}
			} else {

				if( snap ) angle = Snap(angle, ref nearestMultiple);		
				
				if( !ranged ) {
					ValueAngle = angle;

				} else {
					if( Drags.None == drag ) {
						RangeAngle = angle;

					} else if( Drags.Left==drag ) {
						ValueAngle = angle;

					} else if( Drags.Right == drag ) {
						RangeAngle = angle;

					} else if( Drags.Center == drag ) {

						angle = AngleAt(new Point(e.X, e.Y));
						

						float valueAng = angle-valueAngleDiff;
						float rangeAng = valueAng + (rangeAngle-valueAngle);
						float inc = 0;
						if( snap ) {
							int snapped = 0;
							int tick1 = -1;
							float snapValue = Snap(valueAng, ref tick1);
							float inc1 = float.MaxValue;
							if( valueAng != snapValue ) {
								inc1 = snapValue-valueAng;
								snapped = 1;
							}
							
							int tick2 = -1;
							snapValue = Snap(rangeAng, ref tick2);
							float inc2 = float.MaxValue;
							if( rangeAng != snapValue ) {
								inc2 = snapValue-rangeAng;
								snapped = 2;
							}
							
							if( snapped != 0 ) {
								if( Math.Abs(inc1) > Math.Abs(inc2) ){
									inc = inc2;
									snapped = 2;
								}
								else {
									inc = inc1;
									snapped = 1;
								}
							}	
							
							if( 1==snapped ) tick = tick1;
							else if( 2==snapped ) tick = tick2;
							else tick = -1;
						}

						if( valueAng+inc > 360.0f-baseAngle ) {
							inc = 360.0f-baseAngle - valueAng;
						} else if( valueAng+inc < baseAngle ) {
							inc = baseAngle - valueAng;
						} else if( rangeAng+inc > 360.0f-baseAngle) {
							inc = 360.0f-baseAngle - rangeAng;
						} else if( rangeAng+inc < baseAngle ) {
							inc = baseAngle - rangeAng;
						}

						ValueAngle = valueAng+inc;
						RangeAngle = rangeAng+inc;
						
						holdAngle = angle;
					}

				}
				if( ValueChanged != null ) ValueChanged();
			}
			Invalidate();

		}


		enum MouseOver {
			Left,
			Right,
			Center,
			Reset,
			None
		}
		MouseOver mouseOver = MouseOver.None;

		int tick;

		private float BarRadius() {
			float pixelsWide = 0.0f;
			if( radius <= 20 ) pixelsWide = 5.0f;
			else if( radius <= 40 ) pixelsWide = (radius-20.0f)/20.0f*5.0f + 5.0f;
			else pixelsWide = 10.0f;

			return (float)(Math.Asin(pixelsWide/radius)*180.0/Math.PI);
		}
			
		float SmallRadius() {
			return Math.Max(radius * 0.1f, 4);
		}
		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
			mouseDown = false;
			drag = Drags.None;
		}

		float Snap(float ang) {
			int nearestMultiple = -1;
			return Snap(ang, ref nearestMultiple);
		}
		float Snap(float ang, ref int nearestMultiple) {
			ang -= baseAngle;
			float inc = (360.0f-2.0f*baseAngle) / ((tickCount+1)*(tacksPerTick+1));
			nearestMultiple = (int)Math.Round(ang/inc);
			if( Math.Abs(ang - inc*nearestMultiple) < 5.0f ) ang = inc*nearestMultiple;
			ang = ang+baseAngle ;
			if( ang >= 360.0f ) ang = 0.0f;
			return ang;
		}

		float AngleAt(Point point) {
			double x = point.X-centerX;
			double y = point.Y-centerY;
			double mag = Math.Sqrt(x*x + y*y);
			y /= mag;
			float ang = (float)(Math.Acos(y) * 180.0/Math.PI);
			if( x>0.0f ) ang = 360.0f - ang;

			if( ang <= baseAngle ) ang = baseAngle;
			else if( ang >= 360.0f - baseAngle ) ang = 360.0f-baseAngle;
			
			return ang;
		}

		double ValueAt(double relativeAngle) {
			return (relativeAngle / (360.0-2.0*baseAngle)) * (max-min) + min;
		}

		void DrawDialCircumference(Graphics g) {
			LinearGradientBrush brush = new LinearGradientBrush(new RectangleF(centerX-radius, centerY-radius, radius*2.0f, radius*2.0f), Color.FromArgb(150, 0, 0, 0), Color.FromArgb(150, 255, 255, 255), 45.0f);

			g.DrawArc(new Pen(brush, 3), centerX-radius, centerY-radius, radius*2.0f, radius*2.0f, 90+baseAngle, 360.0f - 2.0f*baseAngle);
			brush.Dispose();
		}

		void DrawDial(Graphics g) {
			DrawDialCircumference(g);

			GraphicsPath path = new GraphicsPath();
			path.AddPie(centerX-radius, centerY-radius, radius*2.0f, radius*2.0f, 90+baseAngle, 360.0f - 2.0f*baseAngle);

			PathGradientBrush brush = new PathGradientBrush(path);
			brush.SurroundColors = new Color[] { Color.FromArgb(64, 0, 255, 0) };
			brush.CenterColor = Color.FromArgb(255, 201, 255, 185);
			brush.FocusScales = new PointF(0.5f, 0.5f);
			g.FillPie(brush, centerX-radius, centerY-radius, radius*2.0f, radius*2.0f, 90+baseAngle, 360.0f - 2.0f*baseAngle);
			brush.Dispose();
		
		}

		void DrawValue(Graphics g) {
			float phi = valueAngle+90;
			float x = (float)(centerX + radius*Math.Cos(phi*Math.PI/180.0));
			float y = (float)(centerY + radius*Math.Sin(phi*Math.PI/180.0));

			float barRadius = BarRadius();

			int highlight = (MouseOver.Left==mouseOver) ? 150 : 0;

			GraphicsPath path = new GraphicsPath();
			path.AddPie(centerX-radius, centerY-radius, 2.0f*radius, 2.0f*radius, phi-barRadius/2.0f, barRadius);

			PathGradientBrush brush = new PathGradientBrush(path);
			brush.CenterColor = Color.FromArgb(255, 255, 255, highlight);
			brush.SurroundColors = new Color[] { Color.FromArgb(highlight/2, 255, 255, highlight) };
			brush.FocusScales = new PointF(.5f, .5f);
			g.FillPie(brush, centerX-radius, centerY-radius, 2.0f*radius, 2.0f*radius, phi-barRadius/2.0f, barRadius);
			brush.Dispose();
		}

		void DrawRange(Graphics g) {
			if( Math.Abs(rangeAngle-valueAngle) <= float.Epsilon ) return;

			float phi = valueAngle+90;
			float x = (float)(centerX + radius*Math.Cos(phi*Math.PI/180.0));
			float y = (float)(centerY + radius*Math.Sin(phi*Math.PI/180.0));

			float barRadius = BarRadius();
			int highlight = (MouseOver.Center==mouseOver) ? 150 : 0;

			SolidBrush brush = new SolidBrush(Color.FromArgb(64+highlight/2, 255, 255, highlight));
			g.FillPie(brush, centerX-radius, centerY-radius, 2.0f*radius, 2.0f*radius, phi, rangeAngle-valueAngle);

			highlight = (MouseOver.Right==mouseOver) ? 150 : 0;

			brush.Color = Color.FromArgb(64+highlight/2, 255, 255, highlight);
			g.FillPie(brush, centerX-radius, centerY-radius, 2.0f*radius, 2.0f*radius, (rangeAngle+90.0f)-barRadius/2.0f, barRadius);
			brush.Dispose();
		}

		void DrawTicks(Graphics g) {
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;

			int modifiedTickCount = tickCount;
			if( 0.0f == baseAngle ) ++modifiedTickCount;

			double angleInc = (360.0-2*baseAngle) / (modifiedTickCount+1) / (tacksPerTick+1);
			double angle = 90+baseAngle;//+angleInc;
				
			float x, y;
			float x2, y2;
			float dx, dy;

			int tickCounter = 0;

			for( int i=0; i<=modifiedTickCount+1; ++i ) {
				dx = (float)(Math.Cos(angle*Math.PI/180.0));
				dy = (float)(Math.Sin(angle*Math.PI/180.0));
				x = centerX + radius*dx;
				y = centerY + radius*dy;
				x2 = centerX + (radius-Math.Min(15, radius*(15.0f/50.0f)))*dx;
				y2 = centerY + (radius-Math.Min(15, radius*(15.0f/50.0f)))*dy;

				int highlight = (tick==tickCounter) ? 127 : 0;
				Pen pen = new Pen(Color.FromArgb((byte)Math.Min(255, radius*(255.0f/50.0f)), 255, 128+highlight, highlight));
				if( modifiedTickCount != 0 ) g.DrawLine(pen, x, y, x2, y2);

				if( (radius >= 50.0f) && ((TickLabels.EndPoints==labels && (0==i || modifiedTickCount+1==i)) || TickLabels.Ticks==labels) ) {
					if( i<modifiedTickCount+1 || baseAngle>0.0f ) {
						Matrix oldMatrix = g.Transform;
						Matrix textTransform = new Matrix();
						textTransform.Rotate((float)(angle+90.0));
						textTransform.Translate(centerX, centerY, MatrixOrder.Append);
						g.Transform = textTransform;
						g.DrawString(Math.Round(ValueAt(AbsoluteToRelativeAngle(angle)), 2).ToString(), Font, Brushes.Black, 0, -radius+20, sf);
						g.Transform = oldMatrix;
					}
				}

				angle += angleInc;
				++tickCounter;
				
				if( i>modifiedTickCount ) break;

				for( int j=0; j<tacksPerTick; ++j ) {
					dx = (float)(Math.Cos(angle*Math.PI/180.0));
					dy = (float)(Math.Sin(angle*Math.PI/180.0));
					x = centerX + radius*dx;
					y = centerY + radius*dy;
					x2 = centerX + (radius-Math.Min(5, radius*(5.0f/50.0f)))*dx;
					y2 = centerY + (radius-Math.Min(5, radius*(5.0f/50.0f)))*dy;
					
					highlight = (tick==tickCounter) ? 127 : 0;
					pen.Color = Color.FromArgb((byte)Math.Min(255, radius*(255.0f/50.0f)), 255, 128+highlight, highlight);
					g.DrawLine(pen, x, y, x2, y2);

					angle += angleInc;
					++tickCounter;
				}
				
			}
		}
		void DrawAdornments(Graphics g) {
			float smallRadius = SmallRadius();
			int highlight = (MouseOver.Reset==mouseOver) ? 127 : 0;

			GraphicsPath path = new GraphicsPath();
			path.AddPie(centerX-smallRadius, centerY-smallRadius, smallRadius*2.0f, smallRadius*2.0f, 0, 360.0f);//90+baseAngle, 360.0f - 2.0f*baseAngle);

			PathGradientBrush brush = new PathGradientBrush(path);
			brush.SurroundColors = new Color[] { Color.FromArgb(200+highlight/3, highlight, highlight, 128+highlight) };
			brush.CenterColor = Color.FromArgb(highlight/3, highlight, 255, highlight);
			
			g.FillPie(brush, centerX-smallRadius, centerY-smallRadius, smallRadius*2.0f, smallRadius*2.0f, 0, 360.0f);//90+baseAngle, 360.0f - 2.0f*baseAngle);
			brush.Dispose();
		}
		double AbsoluteToRelativeAngle(double angle) {
			double ang = (angle-(baseAngle+90.0));
			if( ang < 0 ) ang += 360.0;
			return ang;
		}

		private void textBox10_TextChanged(object sender, System.EventArgs e) {
			try {
				SplitAngle = float.Parse(textBox10.Text);
			} catch( Exception ) {
			}
		}

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
			textBox7.Text = hScrollBar1.Value.ToString();
		}

		private void hScrollBar2_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
			textBox10.Text = hScrollBar2.Value.ToString();
		}

		private void Form1_Resize(object sender, System.EventArgs e) {
			centerX = (Width-groupBox2.Width)/2;
			centerY = Height/2;
			Invalidate();
		}
		
		
	}
}
