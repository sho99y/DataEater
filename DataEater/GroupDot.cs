using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace DataEater
{
    class GroupDot
    {
        #region Конструктор
        public GroupDot(int id, int x_coordinate, int y_coordinate, Color dotColor, int group)
        {
            Id = id;
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;
            this.dotColor = dotColor;
            Group = group;
        }
        #endregion

        #region Свойства
        public int Group { get; set; }
        public int Id { set; get; }
        public int X_coordinate { get; set; }
        public int Y_coordinate { get; set; }
        public Color dotColor { get; set; }
        #endregion
    }
}