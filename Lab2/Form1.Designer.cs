namespace Lab2
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nUDFriction = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.nUDApha = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nUDHeight = new System.Windows.Forms.NumericUpDown();
			this.nUDWidth = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBoxPuck = new System.Windows.Forms.GroupBox();
			this.nUDAngle = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nUDStrength = new System.Windows.Forms.NumericUpDown();
			this.nUDPosition = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.lableMass = new System.Windows.Forms.Label();
			this.nUDDiameter = new System.Windows.Forms.NumericUpDown();
			this.nUDMass = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDFriction)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDApha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDWidth)).BeginInit();
			this.groupBoxPuck.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDStrength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDPosition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDDiameter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDMass)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel1.Controls.Add(this.groupBoxPuck);
			this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
			this.splitContainer1.Panel1MinSize = 135;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightBlue;
			this.splitContainer1.Size = new System.Drawing.Size(689, 529);
			this.splitContainer1.SplitterDistance = 135;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(14, 494);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 27);
			this.button1.TabIndex = 6;
			this.button1.Text = "Сompute";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.nUDFriction);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.nUDApha);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.nUDHeight);
			this.groupBox1.Controls.Add(this.nUDWidth);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(14, 282);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(104, 206);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Field";
			// 
			// nUDFriction
			// 
			this.nUDFriction.DecimalPlaces = 2;
			this.nUDFriction.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.nUDFriction.Location = new System.Drawing.Point(7, 171);
			this.nUDFriction.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nUDFriction.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nUDFriction.Name = "nUDFriction";
			this.nUDFriction.Size = new System.Drawing.Size(87, 23);
			this.nUDFriction.TabIndex = 7;
			this.nUDFriction.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 153);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 15);
			this.label8.TabIndex = 6;
			this.label8.Text = "Friction force";
			// 
			// nUDApha
			// 
			this.nUDApha.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nUDApha.Location = new System.Drawing.Point(7, 126);
			this.nUDApha.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.nUDApha.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.nUDApha.Name = "nUDApha";
			this.nUDApha.Size = new System.Drawing.Size(87, 23);
			this.nUDApha.TabIndex = 5;
			this.nUDApha.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.nUDApha.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "AphaAngle";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Width";
			// 
			// nUDHeight
			// 
			this.nUDHeight.Location = new System.Drawing.Point(7, 81);
			this.nUDHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nUDHeight.Name = "nUDHeight";
			this.nUDHeight.Size = new System.Drawing.Size(87, 23);
			this.nUDHeight.TabIndex = 3;
			this.nUDHeight.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nUDHeight.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
			// 
			// nUDWidth
			// 
			this.nUDWidth.Location = new System.Drawing.Point(7, 36);
			this.nUDWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nUDWidth.Name = "nUDWidth";
			this.nUDWidth.Size = new System.Drawing.Size(87, 23);
			this.nUDWidth.TabIndex = 1;
			this.nUDWidth.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nUDWidth.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Heigth";
			// 
			// groupBoxPuck
			// 
			this.groupBoxPuck.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBoxPuck.Controls.Add(this.nUDAngle);
			this.groupBoxPuck.Controls.Add(this.label7);
			this.groupBoxPuck.Controls.Add(this.label5);
			this.groupBoxPuck.Controls.Add(this.nUDStrength);
			this.groupBoxPuck.Controls.Add(this.nUDPosition);
			this.groupBoxPuck.Controls.Add(this.label6);
			this.groupBoxPuck.Controls.Add(this.lableMass);
			this.groupBoxPuck.Controls.Add(this.nUDDiameter);
			this.groupBoxPuck.Controls.Add(this.nUDMass);
			this.groupBoxPuck.Controls.Add(this.label1);
			this.groupBoxPuck.Location = new System.Drawing.Point(14, 14);
			this.groupBoxPuck.Name = "groupBoxPuck";
			this.groupBoxPuck.Size = new System.Drawing.Size(104, 260);
			this.groupBoxPuck.TabIndex = 4;
			this.groupBoxPuck.TabStop = false;
			this.groupBoxPuck.Text = "Puck";
			// 
			// nUDAngle
			// 
			this.nUDAngle.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.nUDAngle.Location = new System.Drawing.Point(7, 216);
			this.nUDAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nUDAngle.Name = "nUDAngle";
			this.nUDAngle.Size = new System.Drawing.Size(87, 23);
			this.nUDAngle.TabIndex = 9;
			this.nUDAngle.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 198);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "Strike angle";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Strike strength";
			// 
			// nUDStrength
			// 
			this.nUDStrength.Location = new System.Drawing.Point(7, 171);
			this.nUDStrength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nUDStrength.Name = "nUDStrength";
			this.nUDStrength.Size = new System.Drawing.Size(87, 23);
			this.nUDStrength.TabIndex = 7;
			this.nUDStrength.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nUDStrength.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
			// 
			// nUDPosition
			// 
			this.nUDPosition.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nUDPosition.Location = new System.Drawing.Point(7, 126);
			this.nUDPosition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nUDPosition.Name = "nUDPosition";
			this.nUDPosition.Size = new System.Drawing.Size(87, 23);
			this.nUDPosition.TabIndex = 5;
			this.nUDPosition.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nUDPosition.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 108);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 15);
			this.label6.TabIndex = 6;
			this.label6.Text = "Position";
			// 
			// lableMass
			// 
			this.lableMass.AutoSize = true;
			this.lableMass.Location = new System.Drawing.Point(7, 18);
			this.lableMass.Name = "lableMass";
			this.lableMass.Size = new System.Drawing.Size(33, 15);
			this.lableMass.TabIndex = 0;
			this.lableMass.Text = "Mass";
			// 
			// nUDDiameter
			// 
			this.nUDDiameter.Location = new System.Drawing.Point(7, 81);
			this.nUDDiameter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nUDDiameter.Name = "nUDDiameter";
			this.nUDDiameter.Size = new System.Drawing.Size(87, 23);
			this.nUDDiameter.TabIndex = 3;
			this.nUDDiameter.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.nUDDiameter.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
			// 
			// nUDMass
			// 
			this.nUDMass.Location = new System.Drawing.Point(7, 36);
			this.nUDMass.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nUDMass.Name = "nUDMass";
			this.nUDMass.Size = new System.Drawing.Size(87, 23);
			this.nUDMass.TabIndex = 1;
			this.nUDMass.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nUDMass.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Diameter";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(689, 529);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "Form1";
			this.Text = "Puck simulator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.SizeChanged += new System.EventHandler(this.nUD_ValueChanged);
			this.splitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDFriction)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDApha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDWidth)).EndInit();
			this.groupBoxPuck.ResumeLayout(false);
			this.groupBoxPuck.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDStrength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDPosition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDDiameter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nUDMass)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown nUDApha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nUDHeight;
		private System.Windows.Forms.NumericUpDown nUDWidth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBoxPuck;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nUDStrength;
		private System.Windows.Forms.NumericUpDown nUDPosition;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lableMass;
		private System.Windows.Forms.NumericUpDown nUDDiameter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nUDAngle;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown nUDFriction;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown nUDMass;
	}
}

