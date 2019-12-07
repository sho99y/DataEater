using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEater
{
    class ResultArray
    {

        public  List<GroupDot> groupDots = new List<GroupDot>();
        public ResultForel resultForel { get; set; }

        public ResultArray(ResultForel resultForel, List<GroupDot> list)
        {
            this.resultForel = resultForel;
            foreach (GroupDot value in list) groupDots.Add(value);
        }
    }
}