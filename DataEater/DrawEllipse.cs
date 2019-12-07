using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DataEater
{
    class DrawEllipse: Draw
    {
        Pen default_pen = new Pen(Color.Black);

        #region Конструктор
        public DrawEllipse(PictureBox picture) : base(picture) { }
        #endregion

        #region Методы
        public void circle(int x_coordinate, int y_coordinate, int size)
        {
            drawPlace.DrawEllipse(default_pen, x_coordinate - size/2 , y_coordinate - size/2 , size, size); 
        }

        public void reDraw(List<int> list)
        {
            drawPlace.Clear(Color.FromArgb(200, 200, 200));
            drawList(list);
        }

        public override void refresh()
        {
            base.refresh();
            circle(DataDot.X_center(), DataDot.Y_center(), (int)(DataDot.diametr() * 0.5));
        }
        #endregion
    }
}