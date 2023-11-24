using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShananinaVV.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string strX = str.Replace('.', ',');
            double res = Math.Round((Math.Pow(Convert.ToDouble(strX), 3) * 1.2 * Convert.ToDouble(strX) + 2), 3);
            return res;
        }
    }
}
