using System;
using System.Drawing;

namespace ArduinoRadar
{
    class Radar
    {
        private float[] angles;
        private int radarLines;
        private int width, height;
        private Color radar_color, bgColor;
        private Bitmap bmp, dots;
        private Graphics g1, g2;
        private Pen pen_radar;
        private int prev = 90, angle = 90, distance;
        private bool reverse;
        private Random rand;

        public Radar(int radarLines, int width, int height, Color radar_color, Color bgColor)
        {
            this.radarLines = radarLines;
            this.width = width;
            this.height = width;
            this.radar_color = radar_color;
            this.bgColor = bgColor;
            init();
        }

        private void init()
        {
            bmp = new Bitmap(width, height);
            g1 = Graphics.FromImage(bmp);
            g1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            dots = new Bitmap(width, height);
            g2 = Graphics.FromImage(dots);
            g2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            angles = new float[radarLines];
            pen_radar = new Pen(radar_color, 2);
            rand = new Random();

            for (int i = 0; i < radarLines; i++)
            {
                angles[i] = 1 + (0.6f * i);
            }
        }

        public void update(string indata)
        {
            string[] splitted = indata.Split(',');
            prev = angle;
            angle = Math.Abs(int.Parse(splitted[0]));
            distance = int.Parse(splitted[1]) * (width - 100) / 30;

            if (angle > 185)
            {
                angle = (prev > 185) ? 180 : prev;
            }
            else if (angle < -5)
            {
                angle = (prev < -5) ? 0 : prev;
            }
            else if (Math.Abs(angle - prev) > 90)
            {
                angle = prev;
            }

            reverse = (int.Parse(splitted[0]) > 0) ? false : true;

            for (int i = 1; i <= radarLines; i++)
            {
                angles[i - 1] = (reverse) ? angle + (0.8f * i) : angle - (0.8f * i);
            }
        }

        public Bitmap draw()
        {
            int x, y, i;
            Pen p;

            g1.Clear(bgColor);
            pen_radar.Width = 1;

            for (i = 2; i <= 5; i++)
            {
                g1.DrawArc(pen_radar, 50 * i, 50 * i, width - (100 * i), height - (100 * i), 0, -180);
            }

            for (i = 1; i < 9; i++)
            {
                x = (int)(Math.Cos(i * 10 * Math.PI / 180) * (width / 2 - 25 - 7));
                y = (int)(Math.Sin(i * 10 * Math.PI / 180) * (height / 2 - 25 - 7));
                g1.DrawLine(pen_radar, width / 2, height / 2, width / 2 + x, height / 2 - y);
                g1.DrawLine(pen_radar, width / 2, height / 2, width / 2 - x, height / 2 - y);
            }

            pen_radar.Width = 2;
            g1.DrawLine(pen_radar, width / 2, height / 2, width / 2, 25);

            if (distance < width - 100)
            {
                x = (int)(Math.Cos(angle * Math.PI / 180) * (distance / 2 - 50));
                y = (int)(Math.Sin(angle * Math.PI / 180) * (distance / 2 - 50));

                int t = rand.Next(20) + 10;
                g2.FillEllipse(new SolidBrush(Color.FromArgb(80, Color.Red)), (width / 2) + x, (height / 2) - y, t, t);
            }

            g1.DrawImage(dots, 0, 0, dots.Width, dots.Height);

            for (i = 0; i < radarLines; i++)
            {
                x = (int)(Math.Cos(angles[i] * Math.PI / 180) * (width / 2 - 50));
                y = (int)(Math.Sin(angles[i] * Math.PI / 180) * (height / 2 - 50));
                p = new Pen(Color.FromArgb(255 - (i * 8) + i, radar_color.R, radar_color.G, radar_color.B), 3);

                g1.DrawLine(p, width / 2, height / 2, width / 2 + x, height / 2 - y);
            }

            g1.DrawArc(pen_radar, 50, 50, width - 100, height - 100, 0, -180);
            g1.DrawLine(pen_radar, 25, height / 2, width - 25, height / 2);
            g1.FillRectangle(new SolidBrush(bgColor), 0, (height / 2) + 1, width, height / 2);

            return bmp;
        }
    }
}
