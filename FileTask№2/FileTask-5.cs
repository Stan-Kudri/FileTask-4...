using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask_2
{
    class FileTask_5
    {
        //№5: Дан текстовый файл.Переписать его содержимое в новый файл, обрезав длину исходных строк согласно числу, значение которое передано в метод.
        private List<string> txt = new List<string>();

        public void Task5(string path, int characters, string newpath)
        {            
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                while(!streamReader.EndOfStream)
                {
                    string str = streamReader.ReadLine();
                    if (str.Length > characters)
                    {
                        txt.Add(str.Substring(0, characters));
                    }
                    else
                    {
                        txt.Add(str);
                    }                        
                }
            }
            using (StreamWriter streamWriter = new StreamWriter(newpath, false, Encoding.UTF8))
            {
                foreach (string str in txt)
                    streamWriter.WriteLine(str);
            }
        }
    }
}
