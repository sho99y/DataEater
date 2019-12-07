using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEater
{
    static class DataDot
    {
        #region DATA
        static public List<Dot> dots = new List<Dot>();
        static public List<GroupDot> forelArray = new List<GroupDot>();
        static public List<ResultForel> resultForels = new List<ResultForel>();
        static public List<ResultArray> resultArrays = new List<ResultArray>();
        static public List<ColorSet> choseColor = new List<ColorSet>();
        #endregion

        #region Центры и векторы точек
        public static int X_vector()
        {
            int max = 0, min = 9999;

            foreach(Dot value in dots)
            {
                if (value.X_coordinate > max) max = value.X_coordinate;
                if (value.X_coordinate < min) min = value.X_coordinate;
            }

            int result = max - min;
            return result;
        }

        public static int Y_vector()
        {
            int max = 0, min = 9999;

            foreach (Dot value in dots)
            {
                if (value.Y_coordinate > max) max = value.Y_coordinate;
                if (value.Y_coordinate < min) min = value.Y_coordinate;
            }

            int result = max - min;
            return result;
        }

        public static int X_center()
        {
            int  min = 9999;

            foreach (Dot value in dots) if (value.X_coordinate < min) min = value.X_coordinate;

            return  min + X_vector() / 2;
        }

        public static int Y_center()
        {
            int min = 9999;

            foreach (Dot value in dots) if (value.Y_coordinate < min) min = value.Y_coordinate;

            return min + Y_vector() / 2;
        }
        #endregion

        #region Диамерт и Радиус
        static public int diametr()
        {
            return (int)Math.Sqrt(X_vector() * X_vector() + Y_vector() * Y_vector());
        }

        static public int radius()
        {
            return diametr() / 2;
        }
        #endregion
    }
}