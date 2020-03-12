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
            using (StreamReader streamReader = new StreamReader($@"{path}\TextDocumentForTasks.txt", Encoding.Default))
            {
                while (!streamReader.EndOfStream)
                {
                    string str = streamReader.ReadLine();
                    var array = str.ToCharArray();
                    if (array.Length >= 1)
                    {
                        StringBuilder stringBuilder = new StringBuilder(array.Length);
                        stringBuilder.Append(array[array.Length - 1]);
                        stringBuilder.Append(array, 0, array.Length - 1);
                        txt.Add(stringBuilder.ToString());
                    }
                    else
                    {
                        txt.Add(str);
                    }
                }
            }
            using (StreamWriter streamWrite = new StreamWriter($@"{path}\TextDocumentForTasks.txt", false,Encoding.Default))
            {
                foreach (var str in txt)
                    streamWrite.WriteLine(str);
            }                
        }
    }
}
