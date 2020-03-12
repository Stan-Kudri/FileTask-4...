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
            using (StreamReader streamReader = new StreamReader($@"{path}\Task3.txt", Encoding.Default))
            {
                float sum = 0;
                while (!streamReader.EndOfStream)
                {
                    var str = streamReader.ReadLine().Split(' ');
                    foreach (var number in str)
                    {
                        float value;
                        float.TryParse(string.Join("", number.Where(c => char.IsDigit(c))), out value);
                        sum += value;
                    }
                }
                Console.WriteLine($"Сумма чисел в тексте равна: {sum}");
            }
        }

    }
}
