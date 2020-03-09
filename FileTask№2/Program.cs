using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask_2
{
    /* №1: Дан текстовый файл. В каждой строке перенести последний символ в начало строки.
    */

    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath("File-Task");
            DirectoryInfo driveInfo = new DirectoryInfo(path);
            if (!driveInfo.Exists)
                driveInfo.Create();
            var txt = new ModifiedTextLines();


            using (StreamReader streamReader = new StreamReader($@"{path}\TextDocumentForTasks.txt", Encoding.Default))
            {
                while (!streamReader.EndOfStream)
                {
                    string str = streamReader.ReadLine();
                    var array = str.ToCharArray();
                    if (array.Length >= 2)
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

            using (StreamWriter streamWriter = new StreamWriter($@"{path}\TextDocumentForTasks.txt", false))
            {
                for(int i = 1; i < txt.NumberLine; i++)
                {
                    streamWriter.WriteLine(txt.Output(i));
                }
            }

            Console.ReadLine();
        }
    }
}
