using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DataEater
{
    class Draw
    {
        public Graphics drawPlace;
        private int size = 10;

        #region Конструктор
        public Draw(PictureBox picture)
        {
            drawPlace = picture.CreateGraphics();
        }
        #endregion

        #region Методы
        public void DrawDot(int x_coordinate, int y_coordinate, Color color)
        {
            
            SolidBrush default_brush = new SolidBrush(color);
            Pen default_pen = new Pen(color);
            drawPlace.FillEllipse(default_brush, x_coordinate - size / 2, y_coordinate - size / 2, size, size);
            drawPlace.DrawEllipse(default_pen, x_coordinate - size / 2, y_coordinate - size / 2, size, size);
        }

        public void DrawDot(int x_coordinate, int y_coordinate)
        {
            DrawDot(x_coordinate, y_coordinate, Color.Black);
        }

        public void clearPlace()
        {
            drawPlace.Clear(Color.White);
        }

        public void drawList(List<int> list)
        {
            foreach (int value in list)
                DrawDot(DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate, Color.Red);
        }
        #endregion

        #region Виртуальные методы
        public virtual void refresh()
        {
            drawPlace.Clear(Color.White);
            foreach(Dot value in DataDot.dots)
                DrawDot(value.X_coordinate, value.Y_coordinate, value.dotColor);
        }

        public virtual void refresh(List<int> list)
        {
            refresh();
            foreach (int value in list)
                DrawDot(DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate,Color.Red);
        }
        #endregion
    }
}