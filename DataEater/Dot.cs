using System.Drawing;

namespace DataEater
{
    class Dot
    {
        #region Конструктор
        public Dot (int x_coordinate, int y_coordinate, Color dotColor)
        {
            Id = countDot + 1;
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;
            this.dotColor = dotColor;
            countDot++;
        }
        #endregion

        #region Свойства
        public static int countDot = -1;
        public int Id { set; get; }
        public int X_coordinate { get; set; }
        public int Y_coordinate { get; set; }
        public Color dotColor { get; set; }
        #endregion
    }
}