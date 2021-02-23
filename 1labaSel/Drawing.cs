using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1labaSel
{
    class Drawing
    {
        public int Scale;

        public void DrawOXY(Graphics grap, int width, int height)
        {
            float x0 = width / 2;
            float y0 = height / 2;
            Pen pen = new Pen(Color.Black, 3);
            grap.DrawLine(pen, new PointF(0, y0), new PointF(width, y0));//ox
            grap.DrawLine(pen, new PointF(width - 15 + 5, y0 - 15 + 5), new PointF(width, y0)); //стрелочка для х
            grap.DrawLine(pen, new PointF(width - 15 + 5, y0 + 15 - 5), new PointF(width, y0));
            grap.DrawLine(pen, new PointF(x0, 0), new PointF(x0, height));//oy
            grap.DrawLine(pen, new PointF(x0 - 15 + 5, 10), new PointF(x0, 0)); //стрелочка для у
            grap.DrawLine(pen, new PointF(x0 + 15 - 5, 10), new PointF(x0, 0));
        }
        public void DrawNumber(Graphics grap, int width, int height)
        {
            int num = 0;
            float x0 = width / 2;
            float y0 = height / 2;
            Pen pen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);
            grap.DrawString(num.ToString(), font, brush, new Point((int)x0 + 1, (int)y0 + 7));///0
            num++;
            for (float x = x0 + Scale; x < width - Scale + 5; x += Scale)//засечки х
            {
                grap.DrawLine(pen, new PointF(x, y0 - 5), new PointF(x, y0 + 5));
                grap.DrawString(num.ToString(), font, brush, new Point((int)x - 3, (int)y0 + 7));
                num++;
            }
            num = 1;
            for (float y = y0 - Scale; y >= Scale; y -= Scale)//засечки у
            {
                grap.DrawLine(pen, new PointF(x0 - 5, y), new PointF(x0 + 5, y));
                grap.DrawString(num.ToString(), font, brush, new Point((int)x0 + 5, (int)y - 5));
                num++;
            }
        }
        public void DrawSet(Graphics grap, int width, int height)
        {

            float x0 = width / 2;
            float y0 = height / 2;

            float x = Scale;
            float step = 0;
            Pen pen = new Pen(Color.Black, 2);

            while (y0 - Scale * step > 0)//горизонтальные
            {
                grap.DrawLine(pen, new PointF(0, y0 - Scale * step), new PointF(width, y0 - Scale * step));
                grap.DrawLine(pen, new PointF(0, y0 + Scale * step), new PointF(width, y0 + Scale * step));
                step++;
            }
            step = 0;
            while (x0 - Scale * step > 0)//вертикальные
            {
                grap.DrawLine(pen, new PointF(x0 - Scale * step, 0), new PointF(x0 - Scale * step, height));
                grap.DrawLine(pen, new PointF(x0 + Scale * step, 0), new PointF(x0 + Scale * step, height));
                step++;
            }
        }

        public List<PointF> GetFunction (int width, int height)
        {
            List<PointF> points = new List<PointF>();
            double x = -1;
            double result;
            while(x<=1)
            {
                result = Math.Round((Math.Acos(x * x) - x), 3);
                points.Add(new PointF((float)x, (float)result));
                x += 0.0001;
            }
            return points;
        }

        public void ToScreen(Graphics grap, int x0, int y0, int width, int height)
        {
            List<PointF> points = GetFunction(width, height);
            List<PointF> screen = new List<PointF>();

            for(int i = 0; i<points.Count(); i++)
            {
                float x = (float)Math.Round((points[i].X * Scale + x0), 3);
                float y = (float)Math.Round((y0 - points[i].Y * Scale), 3);
                screen.Add(new PointF(x, y));
            }

            Pen pen = new Pen(Color.Red, 2);
            grap.DrawLines(pen, screen.ToArray());
        }

        public void DrawHord(List<PointF> pointhord, int width, int height, Graphics grap)
        {
            int x0 = width / 2;
            int y0 = height / 2;
            for (int i = 0; i < pointhord.Count-1; i+=1)
            {
                float x = (float)Math.Round((pointhord[i].X * Scale + x0), 3);
                float y = (float)Math.Round((Math.Acos(pointhord[i].X * pointhord[i].X) - pointhord[i].X), 3); ;
                y = (float)Math.Round((y0 - y * Scale), 3);

                float x1 = (float)Math.Round((pointhord[i+1].X * Scale + x0), 3);
                float y1 = (float)Math.Round((Math.Acos(pointhord[i+1].X * pointhord[i+1].X) - pointhord[i+1].X), 3);
                y1 = (float)Math.Round((y0 - y1 * Scale), 3);

                Pen pen = new Pen(Color.Green, 2);
                grap.DrawEllipse(pen, x, y, 3, 3);
                grap.DrawEllipse(pen, x1, y1, 3, 3);
                grap.DrawLine(pen, x, y, x1, y1);
            }
        }

        public void DrawSec(List<PointF> pointhord, int width, int height, Graphics grap)
        {
            /*int x0 = width / 2;
            int y0 = height / 2;
            for (int i = 0; i < pointhord.Count; i++)
            {
                Pen pen = new Pen(Color.Green, 2);
                float x = (float)Math.Round((pointhord[i].X * Scale + x0), 3);
                float y = (float)Math.Round((y0 - pointhord[i].Y * Scale), 3);
                grap.DrawLine(pen, x0+8, 8, x, y);
            }*/

            float x0 = width / 2;
            float y0 = height / 2;
            Pen pen = new Pen(Color.Green, 1);
            Limits lim = new Limits();
            for (int i = 0; i < pointhord.Count(); i++)
            {
                float y1 = lim.ColculFunc(pointhord[i].X) - (lim.ColculProiz(pointhord[i].X) * pointhord[i].X);
                float y2 = lim.ColculFunc(pointhord[i].X) + (lim.ColculProiz(pointhord[i].X) * (8 - pointhord[i].X));
                PointF p1 = new PointF(0 + x0, y0 - (y1) * Scale);
                PointF p2 = new PointF(8 * Scale + x0, y0 - (y2) * Scale);
                grap.DrawLine(pen, p1, p2);
            }

        }

    }
}
