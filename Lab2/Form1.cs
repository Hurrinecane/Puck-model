﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows;
using System.Threading;
using System.Windows.Forms;
using System.Numerics;

namespace Lab2
{


	public partial class Form1 : Form
	{
		float mass, radius, position, strength, speed, angle;

		float height, width, friction, alpha;

		float g = 9.80665f;

		int t = 0;

		Stopwatch stopwatch;
		PointF[] box;
		RectangleF puck;

		Thread th;
		Graphics graphics;
		Graphics fG;
		Bitmap btm;

		public Form1()
		{
			InitializeComponent();
			DoubleBuffered = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			stopwatch = new Stopwatch();
			btm = new Bitmap(1920, 1080);
			graphics = Graphics.FromImage(btm);
			fG = splitContainer1.Panel2.CreateGraphics();
			nUD_ValueChanged(sender, e);
			th = new Thread(Draw);
			th.IsBackground = true;
			th.Start();
		}

		private void Draw()
		{
			Pen pen = new Pen(Color.RoyalBlue, 5.0f);
			SolidBrush brush = new SolidBrush(Color.Black);

			while (true)
			{
				graphics.Clear(Color.LightBlue);
				graphics.DrawLines(pen, box);
				if (stopwatch.IsRunning)
					if (strength > 0)
					{
						t++;
						strength -= friction * g;
						speed = strength / mass;
						puck.X += speed * (float)Math.Cos(angle) * t / 100;
						puck.Y += speed * (float)Math.Sin(-angle) * t / 100;
						var tmp = circleLineCollision(puck, box);
						if (tmp >= 0)
							angle = (180 + angle);
					}
					else
					{
						MessageBox.Show("Затраченное время: " + stopwatch.Elapsed.TotalSeconds + "\r\n");
						stopwatch.Reset();
						Reset();
					}
				else graphics.DrawLine(new Pen(Color.BlueViolet), puck.X + puck.Width / 2, puck.Y + puck.Width / 2, puck.X + puck.Width / 2 + puck.Width * (float)Math.Cos(angle), puck.Y + puck.Width / 2 + puck.Width * (float)Math.Sin(-angle));

				graphics.FillEllipse(brush, puck);
				fG.DrawImage(btm, 0, 0);
			}
		}
		private double circleLineCollision(RectangleF rectangle, PointF[] points)
		{
			Vector2 p = new Vector2(rectangle.X + rectangle.Width / 2, rectangle.Y + rectangle.Width / 2);
			for (int i = 0, j = 1; i < box.Length - 1; i++, j++)
			{
				Vector2 p0 = new Vector2(points[i].X, points[i].Y);
				Vector2 p1 = new Vector2(points[j].X, points[j].Y);
				Vector2 v = p1 - p0;
				Vector2 w = p - p0;

				float c1 = Vector2.Dot(w, v);
				if (c1 <= 0)
					//return (p - p0).Length();
					if ((p - p0).Length() < rectangle.Width / 2)
						return i; //collision!

				float c2 = Vector2.Dot(v, v);
				if (c2 <= c1)
					//return(p - p1).Length();
					if ((p - p1).Length() < rectangle.Width / 2)
						return i; //collision!

				float b = c1 / c2;
				Vector2 Pb = p0 + Vector2.Multiply(v, b);
				if ((p0.X >= p.X && p.X >= p1.X) || (p0.X <= p.X && p.X <= p1.X) ||
					(p0.Y >= p.Y && p.Y >= p1.Y) || (p0.Y <= p.Y && p.Y <= p1.Y))
					//return (p - Pb).Length();
					//return (p - Pb).Length();
					if ((p - Pb).Length() < rectangle.Width / 2)
						return i; //collision!
			}
			return -1;
		}

		private void Reset()
		{
			strength = (float)nUDStrength.Value;
			angle = (float)nUDAngle.Value * (float)Math.PI / 180F;
			t = 0;

			float X0 = splitContainer1.Panel2.Width / 2 - width / 2;
			float Y0 = splitContainer1.Panel2.Height / 2 - height / 4;

			puck = new RectangleF(X0 + position, Y0 + height - radius - 1, radius, radius);

			box = new PointF[]
			{
			new PointF(X0, Y0),
			new PointF(X0, Y0 + height),
			new PointF(X0 + width, Y0 + height),
			new PointF(X0 + width, Y0),
			new PointF(X0 + width * (float) Math.Cos(alpha) + width , Y0 - height * (float) Math.Sin(alpha) ),
			new PointF(X0 + width * (float) Math.Cos(alpha), Y0 - height * (float) Math.Sin(alpha)),
			new PointF(X0, Y0),
			};
		}

		private void nUD_ValueChanged(object sender, EventArgs e)
		{
			Reset();
			mass = (float)nUDMass.Value;
			radius = (float)nUDDiameter.Value;
			position = (float)nUDPosition.Value;

			height = (float)nUDHeight.Value / 2;
			width = (float)nUDWidth.Value;
			friction = (float)nUDFriction.Value;
			alpha = (float)nUDApha.Value * (float)Math.PI / 180F;

			fG = splitContainer1.Panel2.CreateGraphics();
			nUDDiameter.Maximum = Convert.ToDecimal(height);
			nUDPosition.Maximum = Convert.ToDecimal(width - radius);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (stopwatch.IsRunning)
			{
				Reset();
				stopwatch.Reset();
			}
			else
				stopwatch.Start();
		}

	}
}
/*private int Collision(double X, double Y, double radius, PointF[] points)
		{
			double x, y, r, a, c, b, d, h;
			r = puck.Width / 2;
			x = puck.X + r;
			y = puck.Y + r;
			for (int i = 0, j = 1; i < box.Length - 1; i++, j++)
			{
				a = Math.Sqrt((x - box[j].X) * (x - box[j].X) + (y - box[j].Y) * (y - box[j].Y));
				b = Math.Sqrt((x - box[i].X) * (x - box[i].X) + (y - box[i].Y) * (y - box[i].Y));
				c = Math.Sqrt((box[i].X - box[j].X) * (box[i].X - box[j].X) + (box[i].Y - box[j].Y) * (box[i].Y - box[j].Y));
				// s = Math.Sqrt((a+b+c)/2*((a+b+c)/2-a)((a+b+c)/2-b)((a+b+c)/2-c))
				h = 2 * Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)) / c;
				d = Math.Sqrt(a * a - h * h);
				if (0 <= h && h <= r)
				{
					return i; //collision!
				}
				else if (d < 0 || d < c)
					if (((box[i].X - x) * (box[i].X - x) + (box[i].Y - y) * (box[i].Y - y)) <= r * r)
					{
						return i;   //collision!
					}
			}

			return -1;
		}
*/
