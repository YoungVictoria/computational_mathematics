using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1labaSel
{
    class Limits
    {
        public float LimA;
        public float LimB;
        double epsilon = 0.0001;
        public double Y;

        /// <summary>
        /// вычислении функции
        /// </summary>
        /// <param name="a1"></param>
        /// <returns></returns>
        public float ColculFunc(float a1)
        {
            float result = (float)Math.Round((Math.Acos(a1 * a1) - a1), 3);
            return result;
        }

        /// <summary>
        /// нахождение границ
        /// </summary>
        public void ColculLimit()
        {
            float middle = (float)Math.Round(((LimB + LimA) / 2),3);
            float tempa = LimA;
            float tempb = LimB;
            while (tempa != 0 && tempb != 0 || tempa > epsilon && tempb > epsilon)
            {
                middle = (float)Math.Round(((LimB + LimA) / 2), 3);
                tempa = ColculFunc(LimA);
                if (tempa == 0)
                    Y = LimA;
                tempb = ColculFunc(middle);
                if (tempb == 0)
                    Y = middle;
                if (tempa > 0 && tempb < 0 || tempa < 0 && tempb > 0)
                    LimB = middle;
                else
                {
                    tempa = ColculFunc(middle);
                    if (tempa == 0)
                        Y = middle;
                    tempb = ColculFunc(LimB);
                    if (tempb == 0)
                        Y = LimB;
                    if (tempa > 0 && tempb < 0 || tempa < 0 && tempb > 0)
                        LimA = middle;
                }
            }

        }

        /// <summary>
        /// вычисление функции методом хорд
        /// </summary>
        /// <returns></returns>
        public List<PointF> GetHord()
        {
            Drawing draw = new Drawing();            
           // List<float> pointhord = new List<float>();
           List<PointF> pointhord = new List<PointF>();
            
            while (Math.Abs(LimB-LimA)>epsilon)
            {
                float A = LimA;
                LimA = LimB - (LimB - LimA) * ColculFunc(LimB) / (ColculFunc(LimB) - ColculFunc(LimA));
                pointhord.Add(new PointF(A, ColculFunc(LimA)));
                float B = LimB;
                LimB = LimA - (LimA - LimB) * ColculFunc(LimA) / (ColculFunc(LimA) - ColculFunc(LimB));
                pointhord.Add(new PointF(B, ColculFunc(LimB)));
                Y = LimA;
     
            }
            return pointhord;
        }


        public float ColculProiz(float a1)
        {
            float result = (float)Math.Round(-2*a1 / (Math.Sqrt(1-Math.Pow(a1,4)))-1, 3);
            return result;
        }

        /// <summary>
        /// вычисление функции методом секущих
        /// </summary>
        /// <returns></returns>
        public List<PointF> GetSec()
        {
            List<PointF> pointsec = new List<PointF>();
            float x = 1;
            float y = 2;
            pointsec.Add(new PointF(LimB, ColculFunc(LimB)));
            while (Math.Abs(x-y)>=epsilon)
            {
                x = LimB - ColculFunc(LimB) / ColculProiz(LimB);
                y = LimB - (LimB - LimA) / (ColculFunc(LimB) - ColculFunc(LimA)) * ColculFunc(LimB);
                LimB = y;
                pointsec.Add(new PointF(x, y));
                Y = LimB;
            }

            return pointsec;
        }

    }
}
