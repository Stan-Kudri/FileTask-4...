using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask_2
{    
    class FileTask_1
    {
        //№1: Дан текстовый файл.В каждой строке перенести последний символ в начало строки.

        private List<string> txt = new List<string>();

        public void Task1(string path)
        {
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                while (!streamReader.EndOfStream)
                {
                    string str = streamReader.ReadLine();                
                    if (str.Length >= 1)
                    {
                        txt.Add(str.Substring(str.Length) + str.Substring(0, str.Length - 1));
                    }
                    else
                    {
                        txt.Add(str);
                    }
                }
            }
            File.WriteAllLines(path, txt,Encoding.UTF8);
        }
    }
}
