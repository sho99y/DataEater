using System;
using System.IO;
using System.Threading.Tasks;

namespace DataEater
{
    class ColorPull
    {
        public ColorPull()
        {
            using (StreamReader sr = new StreamReader(@"D:\project\github\DataEater\DataEater\source\Color.txt"))
            {
                string line = sr.ReadToEnd();
                string[] dataColorS = line.Split(new char[] { ' ', '\n' });
                int[] dataColor = new int[dataColorS.Length];
                for (int i = 0; i <= dataColorS.Length - 1; i++) dataColor[i] = Convert.ToInt32(dataColorS[i]);
                
                for (int i = 0; i <= dataColor.Length - 1; i+=3) 
                {
                    ColorSet colorSet = new ColorSet(dataColor[i], dataColor[i + 1], dataColor[i + 2]);
                    Console.WriteLine($"{dataColor[i]}, {dataColor[i + 1]}, {dataColor[i + 2]}");
                    DataDot.choseColor.Add(colorSet);
                }
            }

        }
    }
}
