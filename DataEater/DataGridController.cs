using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DataEater
{
    class DataGridController
    {
        static public int count = 0;
        static bool test = true;
        DataGridView dataGrid;

        public DataGridController(DataGridView dataGrid)
        {
            this.dataGrid = dataGrid;
            refreshData();
        }

        public void refreshData()
        {
            while (test)
            {
                create_data_grid(dataGrid);
                test = false;
            }
            set_data(dataGrid);
        }
        void create_data_grid(DataGridView dataGrid)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "id";
            column1.Width = 30; 
            column1.Name = "id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.Width = 50;
            column2.HeaderText = "X";
            column2.Name = "x_grid";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.Width = 50;
            column3.HeaderText = "Y";
            column3.Name = "y_grid";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.Width = 50;
            column4.HeaderText = "group";
            column4.Name = "group";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
        }

        public void set_data(DataGridView dataGrid)
        {
            for (int i = count; i <= DataDot.dots.Count - 1; i++)
            {
                dataGrid.Rows.Add(i, DataDot.dots[i].X_coordinate, DataDot.dots[i].Y_coordinate, 0);
            }
            count = DataDot.dots.Count;
        }

        public void setDataForel(DataGridView dataGrid, List<GroupDot> list)
        {
            for(int i = 0; i<= list.Count -1; i++)
            {
                dataGrid.Rows.Add(list[i].Id, list[i].X_coordinate, list[i].Y_coordinate, list[i].Group);
                dataGrid.Rows[i].Cells[3].Style.BackColor = list[i].dotColor;
            }
        }

    }
}