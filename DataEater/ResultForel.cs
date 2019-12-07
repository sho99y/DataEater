using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEater
{
    class ResultForel
    {
        #region Конструктор
        public ResultForel(int Id, double MassValue)
        {
            this.Id = Id;
            this.MassValue = MassValue;
        }
        #endregion

        #region Свойства
        public int Id { get; set; }
        public double MassValue { get; set; }
        #endregion
    }
}