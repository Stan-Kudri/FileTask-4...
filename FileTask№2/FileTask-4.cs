using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask_2
{   
    class FileTask_4
    {
        //№4: Дан текстовый файл. Удалить из него последние 5 строк.

        private List<string> txt = new List<string>();

        public void Task4(string path)
        {
            int count = File.ReadAllLines($@"{path}\Task4.txt").Length;

            using (StreamReader streamReader = new StreamReader($@"{path}\Task4.txt", Encoding.Default))
            {
                while(!streamReader.EndOfStream)
                {
                    if (txt.Count != count - 5)
                        txt.Add(streamReader.ReadLine());
                    else break;
                }
            }

            using (StreamWriter streamWrite = new StreamWriter($@"{path}\Task4.txt", false, Encoding.Default))
            {
                foreach (var str in txt)
                    streamWrite.WriteLine(str);
            }
        }
    }
}
