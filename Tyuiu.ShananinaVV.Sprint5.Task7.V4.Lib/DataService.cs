using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.ShananinaVV.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            //string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V4.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if (((c >= 'А') && (c <= 'Я')) || ((c >= 'а') && (c <= 'я')))
                        {
                            strLine = strLine + "#";
                        }
                        else
                        {
                            strLine = strLine + line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
