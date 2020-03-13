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
        
        public void Task4(string path)
        {
            string[] txt = File.ReadAllLines(path, Encoding.UTF8);
            int delete = 5;
            
            using (StreamWriter streamWrite = new StreamWriter(path, false, Encoding.UTF8))
            {
                for (int i = 0; i < txt.Length - delete; i++)
                    streamWrite.WriteLine(txt[i]);
            }
        }
    }
}
