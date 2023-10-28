﻿using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class FileWriter
{
    public static void Main()
    {



        string dirFolder = @"C:\Users\craas\OneDrive\Рабочий стол\TestFolder";

        DateTime lastEdit = System.IO.File.GetLastWriteTime(dirFolder);

        DateTime now = DateTime.Now;

        TimeSpan interval = now - lastEdit;


        if (interval.Minutes > 30)
        {
            if (Directory.Exists(dirFolder))
            {
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dirFolder);
                    dirInfo.Delete(true);
                    Console.WriteLine("Папка удалена");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Пути не существует");
            }
        }
        else
        {
            Console.WriteLine("В последнее использование папки менее 30 мин.назад");
        }





    }
}
