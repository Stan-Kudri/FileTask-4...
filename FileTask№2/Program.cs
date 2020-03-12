﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask_2
{
    /* №1: Дан текстовый файл. В каждой строке перенести последний символ в начало строки.    
       №2: Имеется текстовый файл. Выяснить, имеется ли в нем строка, начинающаяся с буквы «т». Если да, то определить номер первой из таких строк.
       №3: В текстовом файле записаны вещественные числа (на каждой строчке - несколько, разделены несколькими пробелами, в формате 3.14 2.597) и другие лексемы (не числа). Найти сумму чисел, игнорируя неверные лексемы.
       №4: Дан текстовый файл. Удалить из него последние 5 строк.
       №5: Дан текстовый файл. Переписать его содержимое в новый файл, обрезав длину исходных строк согласно числу, значение которое передано в метод.
       */

    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath("File-Task");
            DirectoryInfo driveInfo = new DirectoryInfo(path);
            if (!driveInfo.Exists)
                driveInfo.Create();

            var task1 = new FileTask_1();
            task1.Task1(path);

            var task2 = new FileTask_2();
            task2.Task2(path);

            var task3 = new FileTask_3();
            task3.Task3(path);

            var task4 = new FileTask_4();
            task4.Task4(path);

            int characters = 5;
            var task5 = new FileTask_5();
            task5.Task5(path, characters);



            Console.ReadLine();
        }
    }
}
