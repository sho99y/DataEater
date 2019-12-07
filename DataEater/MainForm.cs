using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataEater
{
    public partial class MainForm : Form
    {
        #region Ресурсы
        Draw draw;
        DataGridController dataGrid;
        bool checkExist = true;
        int lastTask = 0;
        #endregion

        #region Initialize
        public MainForm()
        {
            InitializeComponent();
            dataGrid = new DataGridController(DataGrid);

            ColorPull colorPull = new ColorPull();
        }
        #endregion

        #region Click in DrawPlace
        private void DrawPlace_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkExist) 
            {
                draw = new Draw(DrawPlace);
                draw.DrawDot(e.X, e.Y);
                Dot dot = new Dot(e.X, e.Y, Color.Black);
                DataDot.dots.Add(dot);
                dataGrid.refreshData();
            }
            
        }
        #endregion

        #region До лучших времен
        private void DataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(e.ColumnIndex.ToString()) == 2)
            {
                Console.WriteLine(DataGrid.Rows[e.RowIndex].Cells[1].Value);
                Console.WriteLine(DataGrid.Rows[e.RowIndex].Cells[2].Value);
                int x = Convert.ToInt32(DataGrid.Rows[e.RowIndex].Cells[1].Value);
                int y = Convert.ToInt32(DataGrid.Rows[e.RowIndex].Cells[2].Value);

                draw = new Draw(DrawPlace);
                draw.DrawDot(x, y);
                Dot dot = new Dot(x, y, Color.Black);
                DataDot.dots.Add(dot);
                DataGridController.count++;
            }
        }
        #endregion

        #region Button Animate and No Animate
        private void forelBut_Click(object sender, EventArgs e)
        {
            checkExist = false;
            Forel forel = new Forel(DrawPlace);
            forel.result(Forel.alphaList, (int)(DataDot.radius() * Convert.ToDouble(ScaleText.Text)), Convert.ToInt32(HowMany.Text));

            refreshPlace();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkExist = false;
            Forel forel = new Forel(DrawPlace);
            forel.result(Forel.alphaList, (int)(DataDot.radius() * Convert.ToDouble(ScaleText.Text)), Convert.ToInt32(HowMany.Text),500);
            draw.clearPlace();

            refreshPlace();
        }
        #endregion

        #region Clear and Refresh
        private void Clear_Click(object sender, EventArgs e)
        {
            checkExist = true;
            GridResult.Rows.Clear();
            DataGrid.Rows.Clear();
            draw.clearPlace();
            Forel.alphaList.Clear();
            Dot.countDot = -1;
            DataDot.dots.Clear();
            DataDot.forelArray.Clear();
            DataDot.resultArrays.Clear();
            DataDot.resultForels.Clear();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            checkExist = true;
            GridResult.Rows.Clear();
            DataGrid.Rows.Clear();
            dataGrid.refreshData();
            draw.refresh();
            Forel.alphaList.Clear();
            DataDot.forelArray.Clear();
            DataDot.resultArrays.Clear();
            DataDot.resultForels.Clear();
        }


        #endregion

        #region Click in Datas Greed
        private void GridResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                draw.clearPlace();
                lastTask = e.RowIndex;
                foreach (GroupDot value in DataDot.resultArrays[e.RowIndex].groupDots)
                    draw.DrawDot(value.X_coordinate, value.Y_coordinate, value.dotColor);
                DataGrid.Rows.Clear();
                dataGrid.setDataForel(DataGrid, DataDot.resultArrays[e.RowIndex].groupDots);
            }
            
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkExist != true && e.RowIndex != -1) 
            {
                draw.clearPlace();
                foreach (GroupDot value in DataDot.resultArrays[lastTask].groupDots)
                {
                    Console.WriteLine((int)DataGrid.Rows[e.RowIndex].Cells[3].Value);
                    if (value.Group == (int)DataGrid.Rows[e.RowIndex].Cells[3].Value) draw.DrawDot(value.X_coordinate, value.Y_coordinate, value.dotColor);
                    else draw.DrawDot(value.X_coordinate, value.Y_coordinate, Color.Gray);
                }
            }
        }
        #endregion

        #region Мееех
        void refreshPlace()
        {
            foreach (ResultArray value in DataDot.resultArrays)
            {
                GridResult.Rows.Add(value.resultForel.Id, value.resultForel.MassValue);
            }

            draw.clearPlace();
            foreach (GroupDot value in DataDot.resultArrays[0].groupDots)
                draw.DrawDot(value.X_coordinate, value.Y_coordinate, value.dotColor);
            DataGrid.Rows.Clear();
            dataGrid.setDataForel(DataGrid, DataDot.resultArrays[0].groupDots);
        }
        #endregion
    }
}
