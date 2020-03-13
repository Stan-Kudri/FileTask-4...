using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask_2
{    
    class FileTask_3
    {
        //№3: В текстовом файле записаны вещественные числа (на каждой строчке - несколько, разделены несколькими пробелами, в формате 3.14 2.597) и другие лексемы (не числа). Найти сумму чисел, игнорируя неверные лексемы.

        public void Task3(string path)
        {
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                float sum = 0;
                var separators = new[] { ' ' };
                while (!streamReader.EndOfStream)
                {
                    var str = streamReader.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);
                    foreach (var number in str)
                    {
                        float value;                        
                        float.TryParse(number, out value);
                        sum += value;
                    }
                }
                Console.WriteLine($"Сумма чисел в тексте равна: {sum}");
            }
        }

    }
}
