using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask_2
{
    //№2: Имеется текстовый файл. Выяснить, имеется ли в нем строка, начинающаяся с буквы «т». Если да, то определить номер первой из таких строк.

    public class FileTask_2
    {
        public void Task2(string path)
        {
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                int number=0;
                while (!streamReader.EndOfStream)
                {                    
                    string str = streamReader.ReadLine();
                    number++;
                    if (str.Length != 0)
                    {
                        if (str.StartsWith("т") || str.StartsWith("Т"))
                        {                            
                            Console.WriteLine($"{number} строка, является первой, которая начинается с буквы <т>: {str}");
                            return;
                        }
                    }                                    
                }
                Console.WriteLine("Строки начинающей с буквы <т> нету!");
            }
        }
    }
}
