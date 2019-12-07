using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace DataEater
{
    class Forel : DrawEllipse
    {
        #region Переменные
        int countGroup = 0;
        int countColor = -1;
        double valueLastMass = 0;
        int lastCenterX = 0;
        int lastCenterY = 0;
        int oldCenterX = 0;
        int oldCenterY = 0;
        Random random = new Random();
        List<double> lastMassCheck = new List<double>();
        List<GroupDot> groupDots = new List<GroupDot>();
        
        static public List<int> proksyList = new List<int>();
        static public List<int> alphaList = new List<int>();
        static public List<int> omegaList = new List<int>();
        static public List<int> MainList = new List<int>();
        #endregion

        #region Конструктор
        public Forel(PictureBox picture) : base(picture)
        {
            foreach (Dot value in DataDot.dots) alphaList.Add(value.Id);
        }
        #endregion

        #region Вывод результатов
        public void result(List<int> list, int radius,int howMany, int speed) 
        {

            foreach (int value in list) MainList.Add(DataDot.dots[value].Id);

            do
            {
                searcherAnimate(MainList, radius,speed);
            } while (MainList.Count != 0);

            countColor = -1;
            countGroup = 0;

            double getValue = 0;
            foreach (int value in lastMassCheck) getValue += value;
            lastMassCheck.Clear();
            ResultForel resultForel1 = new ResultForel(0, getValue);

            ResultArray resultArray1 = new ResultArray(resultForel1, groupDots);
            DataDot.resultArrays.Add(resultArray1);

            groupDots.Clear();


            for (int i = 1; i <= howMany; i++)
            {
                foreach (int value in list) MainList.Add(DataDot.dots[value].Id);

                do
                {
                    searcher(MainList, radius);
                } while (MainList.Count != 0);

                countColor = -1;
                countGroup = 0;

                getValue = 0;
                foreach (int value in lastMassCheck) getValue += value;
                lastMassCheck.Clear();
                ResultForel resultForel = new ResultForel(i, getValue);

                ResultArray resultArray = new ResultArray(resultForel, groupDots);
                DataDot.resultArrays.Add(resultArray);

                groupDots.Clear();

            }
        }

        public void result(List<int> list, int radius,int howMany)
        {
            for (int i = 0; i <= howMany; i++) {
                foreach (int value in list) MainList.Add(DataDot.dots[value].Id);

                do
                {
                    searcher(MainList, radius);
                } while (MainList.Count != 0);

                countColor = -1;
                countGroup = 0;

                double getValue = 0;
                foreach (int value in lastMassCheck) getValue += value;
                lastMassCheck.Clear();
                ResultForel resultForel = new ResultForel(i, getValue);

                ResultArray resultArray = new ResultArray(resultForel, groupDots);
                DataDot.resultArrays.Add(resultArray);

                groupDots.Clear();
            }
            
        }
        #endregion

        #region Ядро форели
        public void searcher(List<int> list, int radius)
        {
            oldCenterX = 0;
            oldCenterY = 0;

            countColor++;

            int randomValue = random.Next(0, list.Count);

            omegaList.Clear();

            foreach (int value in list) if (checkArea(DataDot.dots[list[randomValue]].X_coordinate, DataDot.dots[list[randomValue]].Y_coordinate,
            DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate, radius)) omegaList.Add(value);

            foreach (int value in MainList) if (checkArea(xMass(omegaList), yMass(omegaList),
                DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate, radius)) proksyList.Add(value);

            do
            {
                oldCenterX = lastCenterX;
                oldCenterY = lastCenterY;

                lastCenterX = xMass(omegaList);
                lastCenterY = yMass(omegaList);

                omegaList.Clear();

                foreach (int value in MainList) if (checkArea(lastCenterX, lastCenterY,
                    DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate, radius)) omegaList.Add(value);

                lastCenterX = xMass(omegaList);
                lastCenterY = yMass(omegaList);


            } while (oldCenterX != lastCenterX && oldCenterY != lastCenterY);


            valueLastMass = 0;
            foreach (int value in omegaList)
            {
                valueLastMass += vectorMass(lastCenterX, lastCenterY, DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate);
                GroupDot gDot = new GroupDot(DataDot.dots[value].Id, DataDot.dots[value].X_coordinate,
                    DataDot.dots[value].Y_coordinate, Color.FromArgb(DataDot.choseColor[countColor].R, DataDot.choseColor[countColor].B, DataDot.choseColor[countColor].G), countGroup);
                groupDots.Add(gDot);
                MainList.Remove(DataDot.dots[value].Id);
            }
            countGroup++;
            lastMassCheck.Add(valueLastMass);
        }

        public void searcherAnimate(List<int> list, int radius, double speed) 
        {
            oldCenterX = 0;
            oldCenterY = 0;

            countColor++;

            int randomValue = random.Next(0, list.Count);

            omegaList.Clear();

            foreach (int value in list) if (checkArea(DataDot.dots[list[randomValue]].X_coordinate, DataDot.dots[list[randomValue]].Y_coordinate,
            DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate, radius)) omegaList.Add(value);

            reDraw(MainList);
            circle(DataDot.dots[list[randomValue]].X_coordinate, DataDot.dots[list[randomValue]].Y_coordinate, radius * 2);
            Thread.Sleep((int)speed);

            foreach (int value in MainList) if (checkArea(xMass(omegaList), yMass(omegaList),
                DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate, radius)) proksyList.Add(value);

            do
            {
                oldCenterX = lastCenterX;
                oldCenterY = lastCenterY;

                lastCenterX = xMass(omegaList);
                lastCenterY = yMass(omegaList);

                omegaList.Clear();

                foreach (int value in MainList) if (checkArea(lastCenterX, lastCenterY,
                    DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate, radius)) omegaList.Add(value);

                lastCenterX = xMass(omegaList);
                lastCenterY = yMass(omegaList);

                reDraw(MainList);
                circle(lastCenterX, lastCenterY, radius * 2);
                Thread.Sleep((int)speed);

            } while (oldCenterX != lastCenterX && oldCenterY != lastCenterY);


            valueLastMass = 0;
            foreach (int value in omegaList)
            {
                valueLastMass += vectorMass(lastCenterX, lastCenterY, DataDot.dots[value].X_coordinate, DataDot.dots[value].Y_coordinate);
                GroupDot gDot = new GroupDot(DataDot.dots[value].Id, DataDot.dots[value].X_coordinate,
                    DataDot.dots[value].Y_coordinate, Color.FromArgb(DataDot.choseColor[countColor].R, DataDot.choseColor[countColor].B, DataDot.choseColor[countColor].G), countGroup);
                groupDots.Add(gDot);
                MainList.Remove(DataDot.dots[value].Id);
            }
            countGroup++;
            lastMassCheck.Add(valueLastMass);

            reDraw(MainList);
            circle(lastCenterX, lastCenterY, radius * 2);
            Thread.Sleep((int)speed);
        }
        #endregion

        #region Всякие штуки

        double vectorMass(int x_center, int y_center, int x, int y)
        {
            double a = Math.Pow(Math.Abs(x_center - x), 2);
            double b = Math.Pow(Math.Abs(y_center - y), 2);
            return Math.Sqrt(a + b);
        }

        public int xMass(List<int> list)
        {
            int count = 0;
            foreach (int value in list) count += DataDot.dots[value].X_coordinate;
            return (int)(count / list.Count);
        }
        public int yMass(List<int> list)
        {
            int count = 0;
            foreach (int value in list) count += DataDot.dots[value].Y_coordinate;
            return (int)(count / list.Count);
        }

        public bool checkArea(int x_center, int y_center, int x, int y, int radius)
        {
            bool check = false;
            double a = Math.Pow(Math.Abs(x_center - x), 2);
            double b = Math.Pow(Math.Abs(y_center - y), 2);
            double vector = Math.Sqrt(a + b);
            if (vector <= radius) check = true;
            return check;
        }

        public int X_vector(List<int> list)
        {
            int max = 0, min = 9999;

            foreach (int value in list)
            {
                if (DataDot.dots[value].X_coordinate > max) max = DataDot.dots[value].X_coordinate;
                if (DataDot.dots[value].X_coordinate < min) min = DataDot.dots[value].X_coordinate;
            }

            int result = max - min;
            return result;
        }

        int XCenterList(List<int> list)
        {
            int min = 9999;

            foreach (int value in list) if (DataDot.dots[value].X_coordinate < min) min = DataDot.dots[value].X_coordinate;

            return min + X_vector(list) / 2;
        }

        public int Y_vector(List<int> list)
        {
            int max = 0, min = 9999;

            foreach (int value in list)
            {
                if (DataDot.dots[value].Y_coordinate > max) max = DataDot.dots[value].Y_coordinate;
                if (DataDot.dots[value].Y_coordinate < min) min = DataDot.dots[value].Y_coordinate;
            }

            int result = max - min;
            return result;
        }

        int YCenterList(List<int> list)
        {
            int min = 9999;

            foreach (int value in list) if (DataDot.dots[value].Y_coordinate < min) min = DataDot.dots[value].Y_coordinate;

            return min + Y_vector(list) / 2;
        }
        #endregion
    }
}