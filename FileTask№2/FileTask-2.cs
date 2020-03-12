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
            using (StreamReader streamReader = new StreamReader($@"{path}\Task2.txt", Encoding.Default))
            {
                while (!streamReader.EndOfStream)
                {                    
                    string str = streamReader.ReadLine();
                    if(str.Length != 0)
                    {
                        var latter = str.ToCharArray();
                        if (latter[0] == 'т' || latter[0] == 'Т')
                        {
                            Console.WriteLine($"Первая из строк начинающая с буквы <т>: {str}");
                            return;
                        }
                    }
                                    
                }
                Console.WriteLine("Строки начинающей с буквы <т> нету!");
            }
        }
    }
}
