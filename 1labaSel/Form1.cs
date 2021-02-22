﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1labaSel
{
    public partial class Form1 : Form
    {
        Drawing draw;
        int scale = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grap = Graphics.FromHwnd(pictureBox1.Handle);
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Limits lim = new Limits();
            lim.LimA = 0.2f;//сократить интервал , что бы функция была на нем монотонна
            lim.LimB = 0.9f;
            //List<PointF> pointhord = lim.GetHord(); //хорд
           List<PointF> pointhord = lim.GetSec(); //секущие
            Task.Factory.StartNew(() =>
            {
                grap.Clear(pictureBox1.BackColor);
                draw.DrawOXY(grap, width, height);
                draw.DrawNumber(grap, width, height);
                draw.DrawSet(grap, width, height);
                draw.ToScreen(grap, width / 2, height / 2, width, height);

                //draw.DrawHord(pointhord, width, height, grap);
                draw.DrawSec(pointhord, width, height, grap);
            });

           // Limits lim = new Limits();
            //lim.LimA = 0.7f;//сократить интервал , что бы функция была на нем монотонна
            //lim.LimB = 0.9f;
            //lim.ColculLimit();
            
            string result = /*"Границы: " + lim.LimA.ToString() + " ; " + lim.LimB.ToString() + "\r\n"
                            + */ "F(x) = 0 в точке " + Math.Round(lim.Y, 3).ToString();
            richTextBox1.Text = result;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw = new Drawing();
            draw.Scale = scale;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Graphics grap = Graphics.FromHwnd(pictureBox1.Handle);
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            grap.Clear(pictureBox1.BackColor);

            Limits lim = new Limits();
            lim.LimA = 0.2f;//сократить интервал , что бы функция была на нем монотонна
            lim.LimB = 0.9f;
            //List<PointF> pointhord = lim.GetHord();
            List<PointF> pointhord = lim.GetSec();

            draw.Scale = trackBar1.Value * 5 + scale;
            draw.DrawOXY(grap, width, height);
            draw.DrawNumber(grap, width, height);
            draw.DrawSet(grap, width, height);
            draw.ToScreen(grap, width / 2, height / 2, width, height);

            //draw.DrawHord(pointhord, width, height, grap);
            draw.DrawSec(pointhord, width, height, grap);
        }
    }
}